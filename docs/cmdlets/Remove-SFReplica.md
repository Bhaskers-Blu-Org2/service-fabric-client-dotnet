# Remove-SFReplica
Removes a service replica running on a node.
## Description

This API simulates a Service Fabric replica failure by removing a replica from a Service Fabric cluster. The removal 
closes the replica, transitions the replica to the role None, and then removes all of the state information of the 
replica from the cluster. This API tests the replica state removal path, and simulates the report fault permanent path 
through client APIs. Warning - There are no safety checks performed when this API is used. Incorrect use of this API 
can lead to data loss for stateful services. In addition, the forceRemove flag impacts all other replicas hosted in 
the same process.



## Required Parameters
#### -NodeName

The name of the node.



#### -PartitionId

The identity of the partition.



#### -ReplicaId

The identifier of the replica.



## Optional Parameters
#### -ForceRemove

Remove a Service Fabric application or service forcefully without going through the graceful shutdown sequence. This 
parameter can be used to forcefully delete an application or service for which delete is timing out due to issues in 
the service code that prevents graceful close of replicas.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



