using System;
using numl.Math.LinearAlgebra;

namespace numl.Math.Metrics
{
    public sealed class CosineDistance : IDistance
    {
        public double Compute(Vector x, Vector y)
        {   
            return 1d - (x.Dot(y) / (x.Norm() * y.Norm()));
        }
    }
}
