# AzurePipelineWeb
Type | Status | Website | Deployment method
-|-|-|-
Web Application | [![Build Status](https://dev.azure.com/Zhiwen-Lin/AzurePipelineWeb/_apis/build/status/AzurePipelineWeb?branchName=master)](https://dev.azure.com/Zhiwen-Lin/AzurePipelineWeb/_build/latest?definitionId=3&branchName=master) | http://demo.codepie.fun | Nginx+Docker+Kubernetes
Sonarqube | [![Build status](https://dev.azure.com/Zhiwen-Lin/AzurePipelineWeb/_apis/build/status/Sonarqube-Azure)](https://dev.azure.com/Zhiwen-Lin/AzurePipelineWeb/_build/latest?definitionId=5) |  | Sonarqube Cloud

### 由于虚拟机配置有限(Kubernetes要求master cpu至少2核以上), 所以会经常出现访问慢或者暂时挂掉的情况(如果pod挂了，kubernetes会重新调度进行restart)

