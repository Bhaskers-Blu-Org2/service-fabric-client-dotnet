# Restart-SFDeployedCodePackage
Restarts a code package deployed on a Service Fabric node in a cluster.
## Description

Restarts a code package deployed on a Service Fabric node in a cluster. This aborts the code package process, which 
will restart all the user service replicas hosted in that process.



## Required Parameters
#### -NodeName

The name of the node.



#### -ApplicationId

The identity of the application. This is typically the full name of the application without the 'fabric:' URI scheme.
                    Starting from version 6.0, hierarchical names are delimited with the "~" character.
                    For example, if the application name is "fabric:/myapp/app1", the application identity would be 
"myapp~app1" in 6.0+ and "myapp/app1" in previous versions.



#### -ServiceManifestName

The name of service manifest that specified this code package.



#### -CodePackageName

The name of the code package defined in the service manifest.



#### -CodePackageInstanceId

The instance ID for currently running entry point. For a code package setup entry point (if specified) runs first and 
after it finishes main entry point is started.
                    Each time entry point executable is run, its instance ID will change. If 0 is passed in as the 
code package instance ID, the API will restart the code package with whatever instance ID it is currently running.
                    If an instance ID other than 0 is passed in, the API will restart the code package only if the 
current Instance ID matches the passed in instance ID.
                    Note, passing in the exact instance ID (not 0) in the API is safer, because if ensures at most one 
restart of the code package.



## Optional Parameters
#### -ServicePackageActivationId

The ActivationId of a deployed service package. If ServicePackageActivationMode specified at the time of creating the 
service
                    is 'SharedProcess' (or if it is not specified, in which case it defaults to 'SharedProcess'), then 
value of ServicePackageActivationId
                    is always an empty string.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



