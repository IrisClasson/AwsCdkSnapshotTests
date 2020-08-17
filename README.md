# Aws Cdk Snapshot Tests with Jest

This repository contains code described in the following blog post : [AWS CDK Cloudformation Integration Tests Using Jest Snapshot Tests](https://www.irisclasson.com/2020/08/13/aws-cdk-cloudformation-integration-tests-using-jest-snapshot-tests/)

### To build, pack and run tests 

Run script in root directory:
```
./test/run.sh
```


### Update snapshots:
```
npm --prefix test/ test -- -u
```
### Run tests
```
npm --prefix test/ test
```
