# Get-SFApplicationHealth
Gets the health of the service fabric application.
## Description

Returns the heath state of the service fabric application. The response reports either Ok, Error or Warning health 
state. If the entity is not found in the health store, it will return Error.



## Optional Parameters
#### -EventsHealthStateFilter

Allows filtering the collection of HealthEvent objects returned based on health state.
                    The possible values for this parameter include integer value of one of the following health states.
                    Only events that match the filter are returned. All events are used to evaluate the aggregated 
health state.
                    If not specified, all entries are returned. The state values are flag-based enumeration, so the 
value could be a combination of these values, obtained using the bitwise 'OR' operator. For example, If the provided 
value is 6 then all of the events with HealthState value of OK (2) and Warning (4) are returned.
                    
                    - Default - Default value. Matches any HealthState. The value is zero.
                    - None - Filter that doesn't match any HealthState value. Used in order to return no results on a 
given collection of states. The value is 1.
                    - Ok - Filter that matches input with HealthState value Ok. The value is 2.
                    - Warning - Filter that matches input with HealthState value Warning. The value is 4.
                    - Error - Filter that matches input with HealthState value Error. The value is 8.
                    - All - Filter that matches input with any HealthState value. The value is 65535.



#### -DeployedApplicationsHealthStateFilter

Allows filtering of the deployed applications health state objects returned in the result of application health query 
based on their health state.
                    The possible values for this parameter include integer value of one of the following health 
states. Only deployed applications that match the filter will be returned.
                    All deployed applications are used to evaluate the aggregated health state. If not specified, all 
entries are returned.
                    The state values are flag-based enumeration, so the value could be a combination of these values, 
obtained using bitwise 'OR' operator.
                    For example, if the provided value is 6 then health state of deployed applications with 
HealthState value of OK (2) and Warning (4) are returned.
                    
                    - Default - Default value. Matches any HealthState. The value is zero.
                    - None - Filter that doesn't match any HealthState value. Used in order to return no results on a 
given collection of states. The value is 1.
                    - Ok - Filter that matches input with HealthState value Ok. The value is 2.
                    - Warning - Filter that matches input with HealthState value Warning. The value is 4.
                    - Error - Filter that matches input with HealthState value Error. The value is 8.
                    - All - Filter that matches input with any HealthState value. The value is 65535.



#### -ServicesHealthStateFilter

Allows filtering of the services health state objects returned in the result of services health query based on their 
health state.
                    The possible values for this parameter include integer value of one of the following health states.
                    Only services that match the filter are returned. All services are used to evaluate the aggregated 
health state.
                    If not specified, all entries are returned. The state values are flag-based enumeration, so the 
value could be a combination of these values,
                    obtained using bitwise 'OR' operator. For example, if the provided value is 6 then health state of 
services with HealthState value of OK (2) and Warning (4) will be returned.
                    
                    - Default - Default value. Matches any HealthState. The value is zero.
                    - None - Filter that doesn't match any HealthState value. Used in order to return no results on a 
given collection of states. The value is 1.
                    - Ok - Filter that matches input with HealthState value Ok. The value is 2.
                    - Warning - Filter that matches input with HealthState value Warning. The value is 4.
                    - Error - Filter that matches input with HealthState value Error. The value is 8.
                    - All - Filter that matches input with any HealthState value. The value is 65535.



#### -ExcludeHealthStatistics

Indicates whether the health statistics should be returned as part of the query result. False by default.
                    The statistics show the number of children entities in health state Ok, Warning, and Error.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



