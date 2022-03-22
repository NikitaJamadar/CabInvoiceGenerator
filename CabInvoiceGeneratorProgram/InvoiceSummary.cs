﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGeneratorProgram
{
    public class InvoiceSummary
    {
        public int numberOfRides;
        public double totalFare;
        public double averageFare;

        public InvoiceSummary(int numberOfRides, double totalFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = this.totalFare / this.numberOfRides;
        }
    }
}
