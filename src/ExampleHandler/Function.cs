using Amazon.Lambda.Core;

namespace ExampleHandler {
    public class Function {
        public int FunctionHandler(string input, ILambdaContext context) {
            return input.Length;
        }
    }
}
