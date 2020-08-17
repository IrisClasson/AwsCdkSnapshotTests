using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;
using Amazon.CDK.AWS.S3;

namespace SnapshotTestExample
{
    public class SnapshotTestExampleStack : Stack
    {
        internal SnapshotTestExampleStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            var function = new Function(this, "stringlength", new FunctionProps {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("./src/ExampleHandler/bin/Release/netcoreapp3.1/ExampleHandler.zip"),
                Handler = "ExampleHandler::ExampleHandler.Function::FunctionHandler"
            });
            var bucket = new Bucket(this, "somebucket", new BucketProps {
                BlockPublicAccess = BlockPublicAccess.BLOCK_ALL
            });
        }
    }
}