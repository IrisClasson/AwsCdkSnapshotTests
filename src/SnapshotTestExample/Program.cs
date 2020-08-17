using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SnapshotTestExample
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new SnapshotTestExampleStack(app, "SnapshotTestExampleStack");
            app.Synth();
        }
    }
}
