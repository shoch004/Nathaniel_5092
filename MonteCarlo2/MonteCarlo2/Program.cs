using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;



namespace MonteCarlo2
{
    /// <summary>
    /// Abstract Class
    /// Option class in inherited by Europpean class, and it will also be inherited
    /// by other options when we have to expand on the MC simulator
    /// Contains abstract properties of an option
    /// Has an abstract price method
    /// </summary>
    public abstract class Option
    {
        public abstract double Underlying { get; set; }
        public abstract double Expiration { get; set; }
        public abstract double Vol { get; set; }
        public abstract double Rate { get; set; }
        public abstract double Tenor { get; set; }
        public abstract double Strike { get; set; }

        public abstract double[] Price(double vol, double rate, double underlying, double strike, double tenor, int path, int step, double[,] rng, bool useAntithetic, bool cv);
    }

    /// <summary>
    /// 
    ///European class inherits from Option class
    /// </summary>
    class European : Option
    {
        public override double Strike { get; set; }
        public bool isCall { get; set; }
        public override double Vol { get; set; }
        public override double Tenor { get; set; }
        public override double Rate { get; set; }

        public override double Underlying { get; set; }
        public override double Expiration { get; set; }

        /// <summary>
        /// 
        ///Overrides the Option Price method.
        ///price and standard error are calculated in this method
        ///There are two cases in this method, the first is when UseAntithetic is true, so we 
        ///price with two price-path matrices that are perfectly negatively correlated and the second when
        ///useAntithetic is false and we price with only one price-path matrix
        /// </summary>
        /// <param name="volatility"></param>
        /// <param name="drift"></param>
        /// <param name="spot"></param>
        /// <param name="expiration"></param>
        /// <param name="path"></param>
        /// <param name="step"></param>
        /// <param name="rng">entered as a parameter to prevent recalculation of randoms</param>
        /// <returns>returns a size == 2 array of doubles. 
        /// index[0] is the price and index[1] is the standard error</returns>
        /// 


        public override double[] Price(double volatility, double drift, double spot, double strike, double expiration, int path, int step, double[,] rng, bool useAntithetic, bool cv)
        {
            //only need the last column of simulated underlying prices for Euro options
            //reuse random numbers by making random number matrix a paramter
            int paths = path;
            int steps = step;
            double[,] randoms = rng;
            double[][,] sim = Simulator.Run(paths, steps, randoms, volatility, drift, spot, strike, expiration, this.isCall, useAntithetic, cv);
            double[,] sim1 = sim[0];
            double[,] sim2 = sim[1];
            double[,] control_variate1 = sim[2];
            double[,] control_variate2 = sim[3];
            double price = 0;
            double sum1 = 0;
            double sum2 = 0;
            double beta1 = -1; //value of -1 suggested by Clewlow pg 97
            double[] opt_prices = new double[paths];
            //case where we using antithetic and not control variate
            if (useAntithetic == true & cv == false)
            {
                if (isCall)
                {
                    for (int i = 0; i < paths; i++)
                    {
                        opt_prices[i] = 0.5 * (Math.Max(0, sim1[i, steps] - Strike) + Math.Max(0, sim2[i, steps] - Strike));
                        sum1 += opt_prices[i];
                        sum2 += opt_prices[i] * opt_prices[i];
                    }
                }
                else
                {
                    for (int i = 0; i < paths; i++)
                    {
                        opt_prices[i] = 0.5 * (Math.Max(0, Strike - sim1[i, steps]) + Math.Max(0, Strike - sim2[i, steps]));
                        sum1 += opt_prices[i];
                        sum2 += opt_prices[i] * opt_prices[i];
                    }

                }
                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };

            }
            //case where we use control variate and not antithetic
            else if (useAntithetic == false & cv == true)
            {
                if (isCall)
                {
                    for (int i = 0; i < paths; i++)
                    {
                        opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike) + beta1 * control_variate1[i, 0];
                        sum1 += opt_prices[i];
                        sum2 += opt_prices[i] * opt_prices[i];
                    }

                }
                else
                {
                    for (int i = 0; i < paths; i++)
                    {
                        opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]) + beta1 * control_variate1[i, 0];
                        sum1 += opt_prices[i];
                        sum2 += opt_prices[i] * opt_prices[i];
                    }
                }
                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };


            }
            //case where we use both antithetic and control variate
            else if (useAntithetic == true & cv == true)
            {
                if (isCall)
                {
                    for (int i = 0; i < paths; i++)
                    {
                        opt_prices[i] = 0.5 * (Math.Max(0, sim1[i, steps] - Strike) + beta1 * control_variate1[i, 0] + Math.Max(0, sim2[i, steps] - Strike) + beta1 * control_variate2[i, 0]);
                        sum1 += opt_prices[i];
                        sum2 += opt_prices[i] * opt_prices[i];
                    }
                }
                else
                {
                    for (int i = 0; i < paths; i++)
                    {
                        opt_prices[i] = 0.5 * (Math.Max(0, Strike - sim1[i, steps]) + beta1 * control_variate1[i, 0] + Math.Max(0, Strike - sim2[i, steps]) + beta1 * control_variate2[i, 0]);
                        sum1 += opt_prices[i];
                        sum2 += opt_prices[i] * opt_prices[i];
                    }
                }
                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };
            }
            //case where we use neither control variate nor antithetic
            else
            {
                if (isCall)
                {
                    for (int i = 0; i < paths; i++)
                    {
                        opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike);
                        price += opt_prices[i];
                    }
                }
                else
                {
                    for (int i = 0; i < paths; i++)
                    {
                        opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]);
                        price += opt_prices[i];
                    }

                }

                double std = 0;
                for (int i = 0; i < paths; i++)
                    std += (opt_prices[i] - (price / paths)) * (opt_prices[i] - (price / paths));
                std = Math.Sqrt(std / (paths - 1));
                double error = std / Math.Sqrt(paths);
                price = (price / paths) * Math.Exp(-Rate * Tenor);
                return new double[2] { price, error };
            }
        }


        /// <summary>
        /// Main method calls the Winforms application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            RunGui();
        }
        static void RunGui()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }

    public class Asian : Option
    {
        public override double Underlying { get; set; }
        public override double Expiration { get; set; }
        public override double Vol { get; set; }
        public override double Rate { get; set; }
        public override double Tenor { get; set; }
        public override double Strike { get; set; }

        public bool isCall { get; set; }

        public override double[] Price(double volatility, double drift, double spot, double strike, double expiration, int path, int step, double[,] rng, bool useAntithetic, bool cv)
        {
            int paths = path;
            int steps = step;
            double[,] randoms = rng;
            double[][,] sim = Simulator.Run(paths, steps, randoms, volatility, drift, spot, strike, expiration, this.isCall, useAntithetic, cv);
            double[,] sim1 = sim[0];
            double[,] sim2 = sim[1];
            double[,] control_variate1 = sim[2];
            double[,] control_variate2 = sim[3];
            double price = 0;
            double sum1 = 0;
            double sum2 = 0;
            double beta1 = -1; //value of -1 suggested by Clewlow pg 97
            double[] opt_prices = new double[paths];
            //case where we using antithetic and not control variate
            if (useAntithetic == true & cv == false)
            {
                if (isCall)
                {
                    double average1;
                    double average2;
                    for (int i = 0; i < paths; i++)
                    {
                        average1 = 0;
                        average2 = 0;
                        for (int j = 0; j < steps + 1; j++)
                        {
                            average1 += sim1[i, j];
                            average2 += sim2[i, j];
                        }
                        opt_prices[i] = 0.5 * (Math.Max(0, (average1 / (steps + 1)) - Strike) + Math.Max(0, (average2 / (steps + 1)) - Strike));
                        sum1 += opt_prices[i];
                        sum2 += opt_prices[i] * opt_prices[i];
                    }

                }
                else
                {
                    double average1;
                    double average2;
                    for (int i = 0; i < paths; i++)
                    {
                        average1 = 0;
                        average2 = 0;
                        for (int j = 0; j < steps + 1; j++)
                        {
                            average1 += sim1[i, j];
                            average2 += sim2[i, j];
                        }
                        opt_prices[i] = 0.5 * (Math.Max(0, Strike - (average1 / (steps + 1))) + Math.Max(0, Strike - (average2 / (steps + 1))));
                        sum1 += opt_prices[i];
                        sum2 += opt_prices[i] * opt_prices[i];
                    }

                }
                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };

            }
            //case where we use control variate and not antithetic
            else if (useAntithetic == false & cv == true)
            {
                double average;
                if (isCall)
                {
                    for (int i = 0; i < paths; i++)
                    {
                        average = 0;
                        for (int j = 0; j < steps + 1; j++)
                        {
                            average += sim1[i, j];

                        }
                        opt_prices[i] = Math.Max(0, (average / (steps + 1)) - Strike) + beta1 * control_variate1[i, 0];
                        sum1 += opt_prices[i];
                        sum2 += opt_prices[i] * opt_prices[i];
                    }

                }
                else
                {
                    for (int i = 0; i < paths; i++)
                    {
                        average = 0;
                        for (int j = 0; j < steps + 1; j++)
                        {
                            average += sim1[i, j];

                        }
                        opt_prices[i] = Math.Max(0, Strike - (average / (steps + 1))) + beta1 * control_variate1[i, 0];
                        sum1 += opt_prices[i];
                        sum2 += opt_prices[i] * opt_prices[i];
                    }
                }
                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };


            }
            //case where we use both antithetic and control variate
            else if (useAntithetic == true & cv == true)
            {
                double average1;
                double average2;
                if (isCall)
                {
                    for (int i = 0; i < paths; i++)
                    {
                        average1 = 0;
                        average2 = 0;
                        for (int j = 0; j < steps + 1; j++)
                        {
                            average1 += sim1[i, j];
                            average2 += sim2[i, j];
                        }
                        opt_prices[i] = 0.5 * (Math.Max(0, (average1 / (steps + 1)) - Strike) + beta1 * control_variate1[i, 0] + Math.Max(0, (average2 / (steps + 1)) - Strike) + beta1 * control_variate2[i, 0]);
                        sum1 += opt_prices[i];
                        sum2 += opt_prices[i] * opt_prices[i];
                    }
                }
                else
                {
                    for (int i = 0; i < paths; i++)
                    {
                        average1 = 0;
                        average2 = 0;
                        for (int j = 0; j < steps + 1; j++)
                        {
                            average1 += sim1[i, j];
                            average2 += sim2[i, j];
                        }
                        opt_prices[i] = 0.5 * (Math.Max(0, Strike - (average1 / (steps + 1))) + beta1 * control_variate1[i, 0] + Math.Max(0, Strike - (average2 / (steps + 1))) + beta1 * control_variate2[i, 0]);
                        sum1 += opt_prices[i];
                        sum2 += opt_prices[i] * opt_prices[i];
                    }
                }
                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };
            }
            //case where we use neither control variate nor antithetic
            else
            {
                if (isCall)
                {
                    for (int i = 0; i < paths; i++)
                    {
                        double average = 0;
                        for (int j = 0; j < steps + 1; j++)
                        {
                            average += sim1[i, j];
                        }
                        opt_prices[i] = Math.Max(0, (average / (steps + 1)) - Strike);
                        price += opt_prices[i];
                    }

                }
                else
                {
                    for (int i = 0; i < paths; i++)
                    {
                        double average = 0;
                        for (int j = 0; j < steps + 1; j++)
                        {
                            average += sim1[i, j];
                        }
                        opt_prices[i] = Math.Max(0, Strike - (average / (steps + 1)));
                        price += opt_prices[i];
                    }

                }

                double std = 0;
                for (int i = 0; i < paths; i++)
                    std += (opt_prices[i] - (price / paths)) * (opt_prices[i] - (price / paths));
                std = Math.Sqrt(std / (paths - 1));
                double error = std / Math.Sqrt(paths);
                price = (price / paths) * Math.Exp(-Rate * Tenor);
                return new double[2] { price, error };
            }
        }
    }

    public class Barrier : Option
    {
        public override double Underlying { get; set; }
        public override double Expiration { get; set; }
        public override double Vol { get; set; }
        public override double Rate { get; set; }
        public override double Tenor { get; set; }
        public override double Strike { get; set; }
        public double barrier_value { get; set; }
        public bool isCall { get; set; }
        public bool down_out { get; set; }
        public bool down_in { get; set; }
        public bool up_out { get; set; }
        public bool up_in { get; set; }



        public override double[] Price(double volatility, double drift, double spot, double strike, double expiration, int path, int step, double[,] rng, bool useAntithetic, bool cv)
        {
            int paths = path;
            int steps = step;
            double[,] randoms = rng;
            double[][,] sim = Simulator.Run(paths, steps, randoms, volatility, drift, spot, strike, expiration, this.isCall, useAntithetic, cv);
            double[,] sim1 = sim[0];
            double[,] sim2 = sim[1];
            double[,] control_variate1 = sim[2];
            double[,] control_variate2 = sim[3];
            double price = 0;
            double sum1 = 0;
            double sum2 = 0;
            double beta1 = -1; //value of -1 suggested by Clewlow pg 97
            double[] opt_prices = new double[paths];
            double[] opt_prices2 = new double[paths];
            double[] opt_total = new double[paths];
            bool worthless;
            bool worthless2;
            //case where we using antithetic and not control variate
            //template from Asian below

            if (useAntithetic == true & cv == false)
            {
                    if (down_in)
                    {
                        for (int i = 0; i < paths; i++)
                        {
                            worthless = true;
                            worthless2 = true;

                            for (int j = 0; j < steps + 1; j++)
                            {
                                if (sim1[i, j] < barrier_value)
                                    worthless = false;
                                if (sim2[i, j] < barrier_value)
                                    worthless2 = false;

                            }
                            if (worthless == true)
                                opt_prices[i] = 0;
                            else
                            {
                                //call
                                if(isCall)
                                    opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike);
                                //put
                                else
                                    opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]);
                            }
                            if (worthless2 == true)
                                opt_prices2[i] = 0;
                            else
                            {
                                //call
                                if (isCall)
                                    opt_prices2[i] = Math.Max(0, sim2[i, steps] - Strike);
                                //put
                                else
                                    opt_prices2[i] = Math.Max(0, Strike - sim2[i, steps]);
                            }


                            opt_total[i] = 0.5 * (opt_prices[i] + opt_prices2[i]);
                            sum1 += opt_total[i];
                            sum2 += opt_total[i] * opt_total[i];



                        }
                    }
                    else if (down_out)
                    {
                        for (int i = 0; i < paths; i++)
                        {
                            worthless = false;
                            worthless2 = false;

                            for (int j = 0; j < steps + 1; j++)
                            {
                                if (sim1[i, j] < barrier_value)
                                    worthless = true;
                                if (sim2[i, j] < barrier_value)
                                    worthless2 = true;

                            }
                            if (worthless == true)
                                opt_prices[i] = 0;
                            else
                            {
                                //call
                                if (isCall)
                                    opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike);
                                //put
                                else
                                    opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]);
                            }
                            if (worthless2 == true)
                                opt_prices2[i] = 0;
                            else
                            {
                                //call
                                if (isCall)
                                    opt_prices2[i] = Math.Max(0, sim2[i, steps] - Strike);
                                //put
                                else
                                    opt_prices2[i] = Math.Max(0, Strike - sim2[i, steps]);
                            }


                            opt_total[i] = 0.5 * (opt_prices[i] + opt_prices2[i]);
                            sum1 += opt_total[i];
                            sum2 += opt_total[i] * opt_total[i];



                        }
                    }
                    else if (up_in)
                    {

                        for (int i = 0; i < paths; i++)
                        {
                            worthless = true;
                            worthless2 = true;

                            for (int j = 0; j < steps + 1; j++)
                            {
                                if (sim1[i, j] > barrier_value)
                                    worthless = false;
                                if (sim2[i, j] > barrier_value)
                                    worthless2 = false;

                            }
                            if (worthless == true)
                                opt_prices[i] = 0;
                            else
                            {
                                //call
                                if (isCall)
                                    opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike);
                                //put
                                else
                                    opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]);
                            }
                            if (worthless2 == true)
                                opt_prices2[i] = 0;
                            else
                            {
                                //call
                                if (isCall)
                                    opt_prices2[i] = Math.Max(0, sim2[i, steps] - Strike);
                                //put
                                else
                                    opt_prices2[i] = Math.Max(0, Strike - sim2[i, steps]);
                            }


                            opt_total[i] = 0.5 * (opt_prices[i] + opt_prices2[i]);
                            sum1 += opt_total[i];
                            sum2 += opt_total[i] * opt_total[i];



                        }
                    }
                    //up and out
                    else
                    {

                        for (int i = 0; i < paths; i++)
                        {
                            worthless = false;
                            worthless2 = false;

                            for (int j = 0; j < steps + 1; j++)
                            {
                                if (sim1[i, j] > barrier_value)
                                    worthless = true;
                                if (sim2[i, j] > barrier_value)
                                    worthless2 = true;

                            }
                            if (worthless == true)
                                opt_prices[i] = 0;
                            else
                            {
                                //call
                                if (isCall)
                                    opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike);
                                //put
                                else
                                    opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]);
                            }
                            if (worthless2 == true)
                                opt_prices2[i] = 0;
                            else
                            {
                                //call
                                if (isCall)
                                    opt_prices2[i] = Math.Max(0, sim2[i, steps] - Strike);
                                //put
                                else
                                    opt_prices2[i] = Math.Max(0, Strike - sim2[i, steps]);
                            }


                            opt_total[i] = 0.5 * (opt_prices[i] + opt_prices2[i]);
                            sum1 += opt_total[i];
                            sum2 += opt_total[i] * opt_total[i];
                        }
                    }
                
                

                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };
            }
            //case where we use control variate and not antithetic
            else if (useAntithetic == false & cv == true)
            {
                    if (down_in)
                    {


                        for (int i = 0; i < paths; i++)
                        {
                            worthless = true;

                            for (int j = 0; j < steps + 1; j++)
                            {
                                if (sim1[i, j] < barrier_value)
                                {
                                    worthless = false;
                                }

                            }
                            if (worthless == true)
                                opt_prices[i] = 0;
                            else
                            {
                                //call
                                if (isCall)
                                    opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike) + beta1 * control_variate1[i, 0];
                                //put
                                else
                                    opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]) + beta1 * control_variate1[i, 0];
                                sum1 += opt_prices[i];
                                sum2 += opt_prices[i] * opt_prices[i];
                            }


                        }
                    }
                    else if (down_out)
                    {
                        for (int i = 0; i < paths; i++)
                        {
                            worthless = false;

                            for (int j = 0; j < steps + 1; j++)
                            {
                                if (sim1[i, j] < barrier_value)
                                {
                                    worthless = true;
                                }

                            }
                            if (worthless == true)
                                opt_prices[i] = 0;
                            else
                            {
                                if (isCall)
                                    opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike) + beta1 * control_variate1[i, 0];
                                else
                                    opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]) + beta1 * control_variate1[i, 0];
                                sum1 += opt_prices[i];
                                sum2 += opt_prices[i] * opt_prices[i];
                            }


                        }
                    }
                    else if (up_in)
                    {

                        for (int i = 0; i < paths; i++)
                        {
                            worthless = true;

                            for (int j = 0; j < steps + 1; j++)
                            {
                                if (sim1[i, j] > barrier_value)
                                {
                                    worthless = false;
                                }

                            }
                            if (worthless == true)
                                opt_prices[i] = 0;
                            else
                            {
                                if (isCall)
                                    opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike) + beta1 * control_variate1[i, 0];
                                else
                                    opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]) + beta1 * control_variate1[i, 0];
                                sum1 += opt_prices[i];
                                sum2 += opt_prices[i] * opt_prices[i];
                            }


                        }

                    }

                    //up and out
                    else
                    {


                        for (int i = 0; i < paths; i++)
                        {
                            worthless = false;

                            for (int j = 0; j < steps + 1; j++)
                            {
                                if (sim1[i, j] > barrier_value)
                                {
                                    worthless = true;
                                }

                            }
                            if (worthless == true)
                                opt_prices[i] = 0;
                            else
                            {
                                if (isCall)
                                    opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike) + beta1 * control_variate1[i, 0];
                                else
                                    opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]) + beta1 * control_variate1[i, 0];
                                sum1 += opt_prices[i];
                                sum2 += opt_prices[i] * opt_prices[i];
                            }


                        }
                    }
                

                
                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };


            }
            //case where we use both antithetic and control variate
            else if (useAntithetic == true & cv == true)
            {
                if (down_in)
                {
                    for (int i = 0; i < paths; i++)
                    {
                        worthless = true;
                        worthless2 = true;

                        for (int j = 0; j < steps + 1; j++)
                        {
                            if (sim1[i, j] < barrier_value)
                                worthless = false;
                            if (sim2[i, j] < barrier_value)
                                worthless2 = false;

                        }
                        if (worthless == true)
                            opt_prices[i] = 0;
                        else
                        {
                            //call
                            if (isCall)
                                opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike) + beta1 * control_variate1[i, 0];
                            //put
                            else
                                opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]) + beta1 * control_variate1[i, 0];
                        }
                        if (worthless2 == true)
                            opt_prices2[i] = 0;
                        else
                        {
                            //call
                            if (isCall)
                                opt_prices2[i] = Math.Max(0, sim2[i, steps] - Strike) + beta1 * control_variate2[i, 0];
                            //put
                            else
                                opt_prices2[i] = Math.Max(0, Strike - sim2[i, steps]) + beta1 * control_variate2[i, 0];
                        }


                        opt_total[i] = 0.5 * (opt_prices[i] + opt_prices2[i]);
                        sum1 += opt_total[i];
                        sum2 += opt_total[i] * opt_total[i];



                    }
                }
                else if (down_out)
                {
                    for (int i = 0; i < paths; i++)
                    {
                        worthless = false;
                        worthless2 = false;

                        for (int j = 0; j < steps + 1; j++)
                        {
                            if (sim1[i, j] < barrier_value)
                                worthless = true;
                            if (sim2[i, j] < barrier_value)
                                worthless2 = true;

                        }
                        if (worthless == true)
                            opt_prices[i] = 0;
                        else
                        {
                            //call
                            if (isCall)
                                opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike) + beta1 * control_variate1[i, 0];
                            //put
                            else
                                opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]) + beta1 * control_variate1[i, 0];
                        }
                        if (worthless2 == true)
                            opt_prices2[i] = 0;
                        else
                        {
                            //call
                            if (isCall)
                                opt_prices2[i] = Math.Max(0, sim2[i, steps] - Strike) + beta1 * control_variate2[i, 0];
                            //put
                            else
                                opt_prices2[i] = Math.Max(0, Strike - sim2[i, steps]) + beta1 * control_variate2[i, 0];
                        }


                        opt_total[i] = 0.5 * (opt_prices[i] + opt_prices2[i]);
                        sum1 += opt_total[i];
                        sum2 += opt_total[i] * opt_total[i];



                    }
                }
                else if (up_in)
                {

                    for (int i = 0; i < paths; i++)
                    {
                        worthless = true;
                        worthless2 = true;

                        for (int j = 0; j < steps + 1; j++)
                        {
                            if (sim1[i, j] > barrier_value)
                                worthless = false;
                            if (sim2[i, j] > barrier_value)
                                worthless2 = false;

                        }
                        if (worthless == true)
                            opt_prices[i] = 0;
                        else
                        {
                            //call
                            if (isCall)
                                opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike) + beta1 * control_variate1[i, 0];
                            //put
                            else
                                opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]) + beta1 * control_variate1[i, 0];
                        }
                        if (worthless2 == true)
                            opt_prices2[i] = 0;
                        else
                        {
                            //call
                            if (isCall)
                                opt_prices2[i] = Math.Max(0, sim2[i, steps] - Strike) + beta1 * control_variate2[i, 0];
                            //put
                            else
                                opt_prices2[i] = Math.Max(0, Strike - sim2[i, steps]) + beta1 * control_variate2[i, 0];
                        }


                        opt_total[i] = 0.5 * (opt_prices[i] + opt_prices2[i]);
                        sum1 += opt_total[i];
                        sum2 += opt_total[i] * opt_total[i];



                    }
                }
                //up and out
                else
                {

                    for (int i = 0; i < paths; i++)
                    {
                        worthless = false;
                        worthless2 = false;

                        for (int j = 0; j < steps + 1; j++)
                        {
                            if (sim1[i, j] > barrier_value)
                                worthless = true;
                            if (sim2[i, j] > barrier_value)
                                worthless2 = true;

                        }
                        if (worthless == true)
                            opt_prices[i] = 0;
                        else
                        {
                            //call
                            if (isCall)
                                opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike) + beta1 * control_variate1[i, 0];
                            //put
                            else
                                opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]) + beta1 * control_variate1[i, 0];
                        }
                        if (worthless2 == true)
                            opt_prices2[i] = 0;
                        else
                        {
                            //call
                            if (isCall)
                                opt_prices2[i] = Math.Max(0, sim2[i, steps] - Strike) + beta1 * control_variate2[i, 0];
                            //put
                            else
                                opt_prices2[i] = Math.Max(0, Strike - sim2[i, steps]) + beta1 * control_variate2[i, 0];
                        }


                        opt_total[i] = 0.5 * (opt_prices[i] + opt_prices2[i]);
                        sum1 += opt_total[i];
                        sum2 += opt_total[i] * opt_total[i];
                    }
                }
                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };
            }
            //case where we use neither control variate nor antithetic
            else
            {

                if (down_in)
                {


                    for (int i = 0; i < paths; i++)
                    {
                        worthless = true;

                        for (int j = 0; j < steps + 1; j++)
                        {
                            if (sim1[i, j] < barrier_value)
                            {
                                worthless = false;
                            }

                        }
                        if (worthless == true)
                            opt_prices[i] = 0;
                        else
                        {
                            //call
                            if (isCall)
                                opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike);
                            //put
                            else
                                opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]);
                            sum1 += opt_prices[i];
                            sum2 += opt_prices[i] * opt_prices[i];
                        }


                    }
                }
                else if (down_out)
                {
                    for (int i = 0; i < paths; i++)
                    {
                        worthless = false;

                        for (int j = 0; j < steps + 1; j++)
                        {
                            if (sim1[i, j] < barrier_value)
                            {
                                worthless = true;
                            }

                        }
                        if (worthless == true)
                            opt_prices[i] = 0;
                        else
                        {
                            if (isCall)
                                opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike);
                            else
                                opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]);
                            sum1 += opt_prices[i];
                            sum2 += opt_prices[i] * opt_prices[i];
                        }


                    }
                }
                else if (up_in)
                {

                    for (int i = 0; i < paths; i++)
                    {
                        worthless = true;

                        for (int j = 0; j < steps + 1; j++)
                        {
                            if (sim1[i, j] > barrier_value)
                            {
                                worthless = false;
                            }

                        }
                        if (worthless == true)
                            opt_prices[i] = 0;
                        else
                        {
                            if (isCall)
                                opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike);
                            else
                                opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]);
                            sum1 += opt_prices[i];
                            sum2 += opt_prices[i] * opt_prices[i];
                        }


                    }
                }
                //up and out
                else
                {


                    for (int i = 0; i < paths; i++)
                    {
                        worthless = false;

                        for (int j = 0; j < steps + 1; j++)
                        {
                            if (sim1[i, j] > barrier_value)
                            {
                                worthless = true;
                            }

                        }
                        if (worthless == true)
                            opt_prices[i] = 0;
                        else
                        {
                            if (isCall)
                                opt_prices[i] = Math.Max(0, sim1[i, steps] - Strike);
                            else
                                opt_prices[i] = Math.Max(0, Strike - sim1[i, steps]);
                            sum1 += opt_prices[i];
                            sum2 += opt_prices[i] * opt_prices[i];
                        }

                    }

                }

                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };
            }
        }
    }

    public class Digital : Option
    {
        public override double Underlying { get; set; }
        public override double Expiration { get; set; }
        public override double Vol { get; set; }
        public override double Rate { get; set; }
        public override double Tenor { get; set; }
        public override double Strike { get; set; }
        public bool isCall { get; set; }
        public double rebate { get; set; }

        public override double[] Price(double volatility, double drift, double spot, double strike, double expiration, int path, int step, double[,] rng, bool useAntithetic, bool cv)
        {
            int paths = path;
            int steps = step;
            double[,] randoms = rng;
            double[][,] sim = Simulator.Run(paths, steps, randoms, volatility, drift, spot, strike, expiration, this.isCall, useAntithetic, cv);
            double[,] sim1 = sim[0];
            double[,] sim2 = sim[1];
            double[,] control_variate1 = sim[2];
            double[,] control_variate2 = sim[3];
            double price = 0;
            double sum1 = 0;
            double sum2 = 0;
            double beta1 = -1; //value of -1 suggested by Clewlow pg 97
            double[] opt_prices = new double[paths];
            double[] opt_prices2 = new double[paths];
            double[] opt_total = new double[paths];
            //case where we using antithetic and not control variate
            if (useAntithetic == true & cv == false)
            {
                for (int i = 0; i < paths; i++)
                {
                    //call
                    if (isCall)
                    {
                        if (sim1[i, steps] > Strike)
                            opt_prices[i] = rebate;
                        else
                            opt_prices[i] = 0;
                        if (sim2[i, steps] > Strike)
                            opt_prices2[i] = rebate;
                        else
                            opt_prices2[i] = 0;
                    }
                    //put
                    else
                    {
                        if (sim1[i, steps] < Strike)
                            opt_prices[i] = rebate;
                        else
                            opt_prices[i] = 0;
                        if (sim2[i, steps] < Strike)
                            opt_prices2[i] = rebate;
                        else
                            opt_prices2[i] = 0;
                    }
                    opt_total[i] = 0.5 * (opt_prices[i] + opt_prices2[i]);
                    sum1 += opt_total[i];
                    sum2 += opt_total[i] * opt_total[i];


                }
                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };

            }
            //case where we use control variate and not antithetic
            else if (useAntithetic == false & cv == true)
            {
                for (int i = 0; i < paths; i++)
                {
                    //call
                    if (isCall)
                    {
                        if (sim1[i, steps] > Strike)
                            opt_prices[i] = rebate + beta1 * control_variate1[i, 0];
                        else
                            opt_prices[i] = 0;
                    }
                    //put
                    else
                    {
                        if (sim1[i, steps] < Strike)
                            opt_prices[i] = rebate + beta1 * control_variate1[i, 0];
                        else
                            opt_prices[i] = 0;
                    }
                    sum1 += opt_prices[i];
                    sum2 += opt_prices[i] * opt_prices[i];


                }
                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };


            }
            //case where we use both antithetic and control variate
            else if (useAntithetic == true & cv == true)
            {
                for (int i = 0; i < paths; i++)
                {
                    //call
                    if (isCall)
                    {
                        if (sim1[i, steps] > Strike)
                            opt_prices[i] = rebate + beta1 * control_variate1[i, 0];
                        else
                            opt_prices[i] = 0;
                        if (sim2[i, steps] > Strike)
                            opt_prices2[i] = rebate + beta1 * control_variate2[i, 0];
                        else
                            opt_prices2[i] = 0;
                    }
                    //put
                    else
                    {
                        if (sim1[i, steps] < Strike)
                            opt_prices[i] = rebate + beta1 * control_variate1[i, 0];
                        else
                            opt_prices[i] = 0;
                        if (sim2[i, steps] < Strike)
                            opt_prices2[i] = rebate + beta1 * control_variate2[i, 0];
                        else
                            opt_prices2[i] = 0;
                    }
                    opt_total[i] = 0.5 * (opt_prices[i] + opt_prices2[i]);
                    sum1 += opt_total[i];
                    sum2 += opt_total[i] * opt_total[i];


                }
                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };
            }
            //case where we use neither control variate nor antithetic
            else
            { 
                    for (int i = 0; i < paths; i++)
                    {
                    //call
                        if (isCall)
                        {
                            if (sim1[i, steps] > Strike)
                                opt_prices[i] = rebate;
                            else
                                opt_prices[i] = 0;
                        }
                        //put
                        else
                        {
                            if (sim1[i, steps] < Strike)
                                opt_prices[i] = rebate;
                            else
                                opt_prices[i] = 0;
                        }
                        sum1 += opt_prices[i];
                        sum2 += opt_prices[i] * opt_prices[i];

                        
                    }
                
                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };
            }
        }
    }

    public class Lookback : Option
    {
        public override double Underlying { get; set; }
        public override double Expiration { get; set; }
        public override double Vol { get; set; }
        public override double Rate { get; set; }
        public override double Tenor { get; set; }
        public override double Strike { get; set; }
        public bool isCall { get; set; }

        public override double[] Price(double volatility, double drift, double spot, double strike, double expiration, int path, int step, double[,] rng, bool useAntithetic, bool cv)
        {
            int paths = path;
            int steps = step;
            double[,] randoms = rng;
            double[][,] sim = Simulator.Run(paths, steps, randoms, volatility, drift, spot, strike, expiration, this.isCall, useAntithetic, cv);
            double[,] sim1 = sim[0];
            double[,] sim2 = sim[1];
            double[,] control_variate1 = sim[2];
            double[,] control_variate2 = sim[3];
            double price = 0;
            double sum1 = 0;
            double sum2 = 0;
            double beta1 = -1; //value of -1 suggested by Clewlow pg 97
            double[] opt_prices = new double[paths];
            double[] opt_prices2 = new double[paths];
            double[] opt_total = new double[paths];
            double max1;
            double max2;
            double min1;
            double min2;
            //case where we using antithetic and not control variate
            if (useAntithetic == true & cv == false)
            {
                for (int i = 0; i < paths; i++)
                {
                    max1 = 0;
                    max2 = 0;
                    min1 = Strike;
                    min2 = Strike;

                    for (int j = 0; j < steps + 1; j++)
                    {
                        if (sim1[i, j] > max1)
                            max1 = sim1[i, j];
                        if (sim2[i, j] > max2)
                            max2 = sim2[i, j];
                        if (sim1[i, j] < min1)
                            min1 = sim1[i, j];
                        if (sim2[i, j] < min2)
                            min2 = sim2[i, j];
                    }
                    if (isCall)
                    {
                        opt_prices[i] = Math.Max(0, max1 - Strike);
                        opt_prices2[i] = Math.Max(0, max2 - Strike);
                    }
                    else
                    {
                        opt_prices[i] = Math.Max(0, Strike - min1);
                        opt_prices2[i] = Math.Max(0, Strike - min2);

                    }
                    opt_total[i] = 0.5 * (opt_prices[i] + opt_prices2[i]);
                    sum1 += opt_total[i];
                    sum2 += opt_total[i] * opt_total[i];
                }

                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };

            }
            //case where we use control variate and not antithetic
            else if (useAntithetic == false & cv == true)
            {
                for (int i = 0; i < paths; i++)
                {
                    max1 = 0;
                    min1 = Strike;
                    for (int j = 0; j < steps + 1; j++)
                    {
                        if (sim1[i, j] > max1)
                            max1 = sim1[i, j];
                        if (sim1[i, j] < min1)
                            min1 = sim1[i, j];
                    }
                    if (isCall)
                        opt_prices[i] = Math.Max(0, max1 - Strike) + beta1 * control_variate1[i, 0];
                    else
                        opt_prices[i] = Math.Max(0, Strike - min1) + beta1 * control_variate1[i, 0];
                    sum1 += opt_prices[i];
                    sum2 += opt_prices[i] * opt_prices[i];
                }

                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };


            }
            //case where we use both antithetic and control variate
            else if (useAntithetic == true & cv == true)
            {
                for (int i = 0; i < paths; i++)
                {
                    max1 = 0;
                    max2 = 0;
                    min1 = Strike;
                    min2 = Strike;

                    for (int j = 0; j < steps + 1; j++)
                    {
                        if (sim1[i, j] > max1)
                            max1 = sim1[i, j];
                        if (sim2[i, j] > max2)
                            max2 = sim2[i, j];
                        if (sim1[i, j] < min1)
                            min1 = sim1[i, j];
                        if (sim2[i, j] < min2)
                            min2 = sim2[i, j];
                    }
                    if (isCall)
                    {
                        opt_prices[i] = Math.Max(0, max1 - Strike) + beta1 * control_variate1[i, 0];
                        opt_prices2[i] = Math.Max(0, max2 - Strike) + beta1 * control_variate2[i, 0];
                    }
                    else
                    {
                        opt_prices[i] = Math.Max(0, Strike - min1) + beta1 * control_variate1[i, 0];
                        opt_prices2[i] = Math.Max(0, Strike - min2) + beta1 * control_variate2[i, 0];

                    }
                    opt_total[i] = 0.5 * (opt_prices[i] + opt_prices2[i]);
                    sum1 += opt_total[i];
                    sum2 += opt_total[i] * opt_total[i];
                }
                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };
            }
            //case where we use neither control variate nor antithetic
            else
            {

                    for (int i = 0; i < paths; i++)
                    {
                        max1 = 0;
                        min1 = Strike;
                        for (int j = 0; j < steps + 1; j++)
                        {
                            if (sim1[i, j] > max1)
                                max1 = sim1[i, j];
                            if (sim1[i, j] < min1)
                                min1 = sim1[i, j];
                        }
                        if (isCall)
                            opt_prices[i] = Math.Max(0, max1 - Strike);
                        else
                            opt_prices[i] = Math.Max(0, Strike - min1);
                        sum1 += opt_prices[i];
                        sum2 += opt_prices[i] * opt_prices[i];
                    }

                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };
            }
        }
    }

    public class Range : Option
    {
        public override double Underlying { get; set; }
        public override double Expiration { get; set; }
        public override double Vol { get; set; }
        public override double Rate { get; set; }
        public override double Tenor { get; set; }
        public override double Strike { get; set; }
        public bool isCall { get; set; }

        public override double[] Price(double volatility, double drift, double spot, double strike, double expiration, int path, int step, double[,] rng, bool useAntithetic, bool cv)
        {
            int paths = path;
            int steps = step;
            double[,] randoms = rng;
            double[][,] sim = Simulator.Run(paths, steps, randoms, volatility, drift, spot, strike, expiration, this.isCall, useAntithetic, cv);
            double[,] sim1 = sim[0];
            double[,] sim2 = sim[1];
            double[,] control_variate1 = sim[2];
            double[,] control_variate2 = sim[3];
            double price = 0;
            double sum1 = 0;
            double sum2 = 0;
            double beta1 = -1; //value of -1 suggested by Clewlow pg 97
            double[] opt_prices = new double[paths];
            double[] opt_prices2 = new double[paths];
            double[] opt_total = new double[paths];
            double max1;
            double max2;
            double min1;
            double min2;
            //case where we using antithetic and not control variate
            if (useAntithetic == true & cv == false)
            {
                for (int i = 0; i < paths; i++)
                {
                    max1 = 0;
                    max2 = 0;
                    min1 = 1000000000;
                    min2 = 1000000000;
                    for (int j = 0; j < steps + 1; j++)
                    {
                        if (sim1[i, j] > max1)
                            max1 = sim1[i, j];
                        if (sim2[i, j] > max2)
                            max2 = sim2[i, j];
                        if (sim1[i, j] < min1)
                            min1 = sim1[i, j];
                        if (sim2[i, j] < min2)
                            min2 = sim2[i, j];
                    }

                    opt_total[i] = 0.5 * ((max1 - min1) + (max2 - min2));

                    sum1 += opt_total[i];
                    sum2 += opt_total[i] * opt_total[i];
                }

                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };

            }
            //case where we use control variate and not antithetic
            else if (useAntithetic == false & cv == true)
            {
                for (int i = 0; i < paths; i++)
                {
                    max1 = 0;
                    min1 = 1000000000;
                    for (int j = 0; j < steps + 1; j++)
                    {
                        if (sim1[i, j] > max1)
                            max1 = sim1[i, j];
                        if (sim1[i, j] < min1)
                            min1 = sim1[i, j];
                    }

                    opt_prices[i] = (max1 - min1) + beta1*control_variate1[i,0];

                    sum1 += opt_prices[i];
                    sum2 += opt_prices[i] * opt_prices[i];
                }

                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };


            }
            //case where we use both antithetic and control variate
            else if (useAntithetic == true & cv == true)
            {
                for (int i = 0; i < paths; i++)
                {
                    max1 = 0;
                    max2 = 0;
                    min1 = 1000000000;
                    min2 = 1000000000;
                    for (int j = 0; j < steps + 1; j++)
                    {
                        if (sim1[i, j] > max1)
                            max1 = sim1[i, j];
                        if (sim2[i, j] > max2)
                            max2 = sim2[i, j];
                        if (sim1[i, j] < min1)
                            min1 = sim1[i, j];
                        if (sim2[i, j] < min2)
                            min2 = sim2[i, j];
                    }

                    opt_total[i] = 0.5 * (((max1 - min1) + beta1*control_variate1[i,0]) + ((max2 - min2) + beta1*control_variate2[i,0]));

                    sum1 += opt_total[i];
                    sum2 += opt_total[i] * opt_total[i];
                }

                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };
            }
            //case where we use neither control variate nor antithetic
            else
            {

                for (int i = 0; i < paths; i++)
                {
                    max1 = 0;
                    min1 = 1000000000;
                    for (int j = 0; j < steps + 1; j++)
                    {
                        if (sim1[i, j] > max1)
                            max1 = sim1[i, j];
                        if (sim1[i, j] < min1)
                            min1 = sim1[i, j];
                    }

                    opt_prices[i] = max1 - min1;

                    sum1 += opt_prices[i];
                    sum2 += opt_prices[i] * opt_prices[i];
                }

                price = (sum1 / paths) * Math.Exp(-Rate * Tenor);
                double std = Math.Sqrt((sum2 - (sum1 * sum1 / paths)) * Math.Exp(-2 * Rate * Tenor) / (paths - 1));
                double error = std / Math.Sqrt(paths);
                return new double[2] { price, error };
            }
        }
    }

    public static class BlackScholes
    {
        /// <summary>
        /// This is a standard normal distribution CDF calculator which was directly taken 
        /// from https://johndcook.com/blog/csharp_phi/ by author John D. Cook. 
        /// </summary>
        /// <param name="x">z-value</param>
        /// <returns></returns>
        public static double Phi(double x)
        {
            // constants
            double a1 = 0.254829592;
            double a2 = -0.284496736;
            double a3 = 1.421413741;
            double a4 = -1.453152027;
            double a5 = 1.061405429;
            double p = 0.3275911;

            // Save the sign of x
            int sign = 1;
            if (x < 0)
                sign = -1;
            x = Math.Abs(x) / Math.Sqrt(2.0);

            // A&S formula 7.1.26
            double t = 1.0 / (1.0 + p * x);
            double y = 1.0 - (((((a5 * t + a4) * t) + a3) * t + a2) * t + a1) * t * Math.Exp(-x * x);

            return 0.5 * (1.0 + sign * y);
        }
        public static double delta(double spot, double strike, double vol, double rate, double tenor, bool isCall)
        {
            double d1 = (Math.Log(spot / strike) + ((rate + ((vol * vol) / 2)) * tenor)) / (vol * Math.Sqrt(tenor));
            double delta = BlackScholes.Phi(d1);
            if (isCall)
                return delta;
            return delta - 1;

        }
    }



    /// <summary>
    /// 
    /// static class because it is just a calculator.
    /// This class contains one method with is the calculator that returns a dictionary
    /// of the greek values. The Calculate method takes the random number matrix as an input
    /// to prevent recalculation of randoms. 
    /// </summary>

    public static class Greeks
    {

        public static Dictionary<string, double> Calculate(int paths, int steps, Option option, double[,] rng, bool useAntithetic, bool cv, double price = -1)
        {
            Dictionary<string, double> greeks = new Dictionary<string, double>();
            double change;
            if (option is Digital)
                change = 0.25;
            else if (option is Lookback || option is Range)
                change = 0.1;
            else
                change = 0.001;
            
            double delta1 = option.Price(option.Vol, option.Rate, option.Underlying - change, option.Strike, option.Tenor, paths, steps, rng, useAntithetic, cv)[0];
            double delta2 = option.Price(option.Vol, option.Rate, option.Underlying + change, option.Strike, option.Tenor, paths, steps, rng, useAntithetic, cv)[0];
            double delta = (delta2 - delta1) / (2 * change);
            greeks.Add("delta", delta);

            if (price == -1)
            {
                price = option.Price(option.Vol, option.Rate, option.Underlying, option.Strike, option.Tenor, paths, steps, rng, useAntithetic, cv)[0];
            }
            double gamma = (delta2 - (2 * price) + delta1) / (change * change);
            greeks.Add("gamma", gamma);

            double vega1 = option.Price(option.Vol - change, option.Rate, option.Underlying, option.Strike, option.Tenor, paths, steps, rng, useAntithetic, cv)[0];
            double vega2 = option.Price(option.Vol + change, option.Rate, option.Underlying, option.Strike, option.Tenor, paths, steps, rng, useAntithetic, cv)[0];
            double vega = (vega2 - vega1) / (2 * change);
            greeks.Add("vega", vega);

            double theta2 = option.Price(option.Vol, option.Rate, option.Underlying, option.Strike, option.Tenor + change, paths, steps, rng, useAntithetic, cv)[0];
            double theta = (theta2 - price) / change;
            greeks.Add("theta", theta);

            double rho1 = option.Price(option.Vol, option.Rate - change, option.Underlying, option.Strike, option.Tenor, paths, steps, rng, useAntithetic, cv)[0];
            double rho2 = option.Price(option.Vol, option.Rate + change, option.Underlying, option.Strike, option.Tenor, paths, steps, rng, useAntithetic, cv)[0];
            double rho = (rho2 - rho1) / (2 * change);
            greeks.Add("rho", rho);

            return greeks;
        }

    }
    /// <summary>
    /// NormRand Class contains the random number generators that are used to calculate the 
    /// normally distributed random numbers.
    /// It contains a method that creates a matrix of standard normal random numbers using
    /// the Box Muller algorithm
    /// </summary>
    class NormRand
    {

        public double PolarRejection()
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            double uniform1 = 10.0;
            double uniform2 = 10.0;
            double w = uniform1 * uniform1 + uniform2 * uniform2;
            while (w >= 1 || w == 0)
            {
                //uniform1,2 are uniform rv's on interval (-1,1)
                uniform1 = rnd1.NextDouble() * 2 - 1.0;
                uniform2 = rnd2.NextDouble() * 2 - 1.0;
                w = uniform1 * uniform1 + uniform2 * uniform2;
            }
            double c = Math.Sqrt(-2 * Math.Log(w) / w);
            double norm = c * uniform1;
            return norm;
        }

        static Random rnd = new Random();
        public double[,] BoxMuller_Matrix(int paths, int steps)
        {
            //Random rnd = new Random(Guid.NewGuid().GetHashCode());
            double[,] randoms = new double[paths, steps];
            for (int i = 0; i < paths; i++)
            {
                for (int j = 0; j < steps; j++)
                {
                    double number1 = rnd.NextDouble();
                    double number2 = rnd.NextDouble();
                    double uniform1 = 1.0 - number1;
                    double uniform2 = 1.0 - number2;
                    double norm = Math.Sqrt(-2 * Math.Log(uniform1)) * Math.Cos(2 * Math.PI * uniform2);
                    randoms[i, j] = norm;

                }
            }

            return randoms;
        }


    }
    /// <summary>
    /// 
    /// Static simulator class, because it is just a calculator. The static Run method takes the random number matrix
    /// as a paramter. It implements the algorithm from chap. 4 of 
    /// "Implementing Derivative Models"
    /// The Run method handles two cases, using Antithetic reduction and not using antithetic
    /// </summary>
    public static class Simulator
    {

        public static double[][,] Run(int paths, int steps, double[,] randMatrix, double vol, double drift, double spot, double strike, double tenor, bool isCall, bool useAntithetic, bool cv)
        {
            double[,] sim1;
            double[,] sim2;
            double time = tenor / steps;
            //nudt term from Clewlow pg 97
            double constant1 = (drift - 0.5 * (vol * vol)) * time;
            //sigsdt term pg 97
            double constant2 = (vol * Math.Sqrt(time));
            //erddt term pg 97
            double constant3 = Math.Exp(drift * time);

            if (randMatrix.Length < paths * steps)
            {
                Console.WriteLine("not enough random numbers, need to generate more");
                return null;
            }
            sim1 = new double[paths, steps + 1];
            //this if statement contains the case where we use control variant and we dont
            //use antithetic variance reduction
            if (cv == true & useAntithetic == false)
            {
                double[,] control_variate = new double[paths, 1];
                double[,] delta_matrix = new double[paths, steps]; // for debugging
                for (int i = 0; i < paths; i++)
                    sim1[i, 0] = spot;
                for (int i = 0; i < paths; i++)
                {
                    double variate = 0;
                    double t;
                    double delta;
                    for (int j = 0; j < steps; j++)
                    {
                        t = j * time;
                        delta = BlackScholes.delta(sim1[i, j], strike, vol, drift, tenor - t, isCall);
                        delta_matrix[i, j] = delta;
                        sim1[i, j + 1] = sim1[i, j] * Math.Exp(constant1 + constant2 * randMatrix[i, j]);
                        variate += delta * (sim1[i, j + 1] - sim1[i, j] * constant3);

                    }
                    control_variate[i, 0] = variate;
                }
                return new[] { sim1, null, control_variate, null };
            }
            //This else-if statement contains the case where we use antithetic v.r. and 
            //using a delta-based control variate
            else if (useAntithetic == true & cv == true)
            {
                sim2 = new double[paths, steps + 1];
                double[,] control_variate1 = new double[paths, 1];
                double[,] control_variate2 = new double[paths, 1];
                for (int i = 0; i < paths; i++)
                {
                    sim1[i, 0] = spot;
                    sim2[i, 0] = spot;
                }
                for (int i = 0; i < paths; i++)
                {
                    double variate1 = 0;
                    double variate2 = 0;
                    double t;
                    double delta1;
                    double delta2;
                    for (int j = 0; j < steps; j++)
                    {
                        t = j * time;
                        delta1 = BlackScholes.delta(sim1[i, j], strike, vol, drift, tenor - t, isCall);
                        delta2 = BlackScholes.delta(sim2[i, j], strike, vol, drift, tenor - t, isCall);
                        sim1[i, j + 1] = sim1[i, j] * Math.Exp(constant1 + constant2 * randMatrix[i, j]);
                        sim2[i, j + 1] = sim2[i, j] * Math.Exp(constant1 + constant2 * -randMatrix[i, j]);
                        variate1 += delta1 * (sim1[i, j + 1] - sim1[i, j] * constant3);
                        variate2 += delta2 * (sim2[i, j + 1] - sim2[i, j] * constant3);

                    }
                    control_variate1[i, 0] = variate1;
                    control_variate2[i, 0] = variate2;
                }
                return new[] { sim1, sim2, control_variate1, control_variate2 };
            }
            //This if statement contains the case where we are using antithetic variance
            //reduction and we are not using a control variate
            else if (useAntithetic == true & cv == false)
            {
                sim2 = new double[paths, steps + 1];
                for (int i = 0; i < paths; i++)
                {
                    sim1[i, 0] = spot;
                    sim2[i, 0] = spot;
                }
                for (int j = 0; j < steps; j++)
                    for (int i = 0; i < paths; i++)
                    {
                        sim1[i, j + 1] = sim1[i, j] * Math.Exp((drift - ((vol * vol) / 2)) * (tenor / steps) + vol * Math.Sqrt(tenor / steps) * randMatrix[i, j]);
                        sim2[i, j + 1] = sim2[i, j] * Math.Exp((drift - ((vol * vol) / 2)) * (tenor / steps) + vol * Math.Sqrt(tenor / steps) * -randMatrix[i, j]);
                    }
                return new[] { sim1, sim2, null, null };
            }
            //This case we use neither antithetic nor control variate
            for (int i = 0; i < paths; i++)
                sim1[i, 0] = spot;
            for (int j = 0; j < steps; j++)
                for (int i = 0; i < paths; i++)
                    sim1[i, j + 1] = sim1[i, j] * Math.Exp(constant1 + constant2 * randMatrix[i, j]);
            return new[] { sim1, null, null, null };
        }

        public static double ArrayAverage(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            return sum / array.Length;
        }
    }
    
}


