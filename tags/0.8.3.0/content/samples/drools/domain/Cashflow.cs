/**
 * Copyright 2010 JBoss Inc
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace org.drools.tutorials.banking
{
    public class Cashflow
    {
        public Cashflow()
        {
        }

        public Cashflow(string date, double amount)
        {
            Date = DateTime.Parse(date);
            Amount = amount;
        }

        public Cashflow(DateTime date, double amount)
        {
            Date = date;
            Amount = amount;
        }

        private DateTime date;
        public DateTime Date
        {
            get
            {
                // Console.WriteLine("getDate");
                return date;
            }
            set { date = value; }
        }

        private double amount;
        public double Amount
        {
            get
            {
                //Console.WriteLine("getAmount");
                return amount;
            }
            set { amount = value; }
        }

        public override String ToString()
        {
            return "Cashflow[date=" + Date + ",amount=" + Amount + "]";
        }
    }
}