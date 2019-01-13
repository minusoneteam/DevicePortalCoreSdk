## Disclaimer
This project is a work in progress with no release yet.

# DevicePortalCoreSDK
Windows Iot - Device Portal - Core API - Software Development Kit

The projects basically provides a "request handler" for the official Device Portal core API mentioned here: [Device Portal core API reference](https://docs.microsoft.com/en-us/windows/uwp/debug-test-perf/device-portal-api-core#set-a-static-ip-address-ipv4-configuration).

It consists of processors that convert requests to functions and group them as microsoft has in the page mentioned above (e.g. Networking, Power, Remote control etc.)

The initial implementation consists of the "Networking Processor" and more will follow.


# Available Processors
## OS Information
1. GetMachineName()
2. GetOSInformation()
3. GetDeviceFamily()
4. SetMachineName(string machineName)

## Remote Control
1. Restart()
2. Shutdown()

## Networking
1. GetConfiguration()
2. PutConfiguration(IPv4AdapterConfiguration configuration)


# Examples
### Using the DevicePortalProcessor
The device portal processor initializes all other processors so the user don't have to manually. An example is shown below:
```C#
DevicePortalProcessor devicePortal = new DevicePortalProcessor("http://localhost:8080/", "username", "password");

NetworkConfiguration configuration = devicePortal.Networking.GetConfiguration();

IPv4AdapterConfiguration newIPv4Config = new IPv4AdapterConfiguration()
{
    DefaultGateway = ...,
    IPAddress = ...,
    Name = ...,
    PrimaryDNS = ...,
    SecondaryDNS = ...,
    SubnetMask = ...
};
devicePortal.Networking.PutConfiguration(newIPv4Config);
```
Alternative, if the user does not want to create all processors (for performance issues and whatnot), he can explicitly create each one he needs.

```C#
RemoteControlProcessor remoteControlProcessor = new RemoteControlProcessor("http://localhost:8080/", new NetworkCredential("username", "password"));
remoteControlProcessor.Restart();
```
