#!/bin/bash
dotnet build src/SnapshotTestExample.sln -c Release
dotnet lambda package -pl src/ExampleHandler/ -c Release
cdk synthesize -o template
find ./template -type f -not -name '*template*' -delete
npm --prefix test/ test
