CoreWCF HTTPS Service Example
=============================

This project demonstrates how to create a simple **CoreWCF** service that communicates over **HTTPS** and how to consume it from a **.NET Framework 4.7** client application. The example helps understand how to establish secure communication between a modern .NET Core service and an older .NET Framework client.

Overview
--------

*   **Service Application**:
    
    *   Built with **.NET 8** using **CoreWCF**.
        
    *   Accessible over HTTPS using BasicHttpBinding.
        
    *   Provides metadata (WSDL) for client-side proxy generation.
        
*   **Client Application**:
    
    *   Built with **.NET Framework 4.7**.
        
    *   Consumes the service by adding a service reference based on WSDL.
        
    *   Demonstrates compatibility between .NET Core and .NET Framework.
        

Key Features
------------

*   **Secure Communication**: Ensures data encryption during transmission using HTTPS.
    
*   **Compatibility**: Enables communication between modern .NET Core services and older .NET Framework clients.
    
*   **WSDL Support**: Availability of metadata for easy client proxy generation.
    

Getting Started
---------------

### Prerequisites

*   **.NET 8 SDK** (for the service application).
    
*   **.NET Framework 4.7 development tools** (for the client application).
    
*   **Visual Studio 2022** or later.
    
*   Basic knowledge of C# and WCF services.
    

### Running the Service Application

1.  **Install NuGet Packages**:
    
    *   Ensure all necessary NuGet packages are installed for the service project.
        
2.  **Build the Service**:
    
    *   Compile the **CoreWCF HTTPS Service** project in Visual Studio.
        
3.  **Trust the Development Certificate** (Development Environment Only):
    
    *   bashCopy codedotnet dev-certs https --trust
        
    *   This allows the service to run over HTTPS without SSL errors.
        
4.  **Run the Service**:
    
    *   Start the service application.
        
    *   The service will be accessible at https://localhost:5001.
        

### Running the Client Application

1.  **Add Service Reference**:
    
    *   arduinoCopy codehttps://localhost:5001/CalculatorService?wsdl
        
    *   This generates the necessary proxy classes to invoke the service methods.
        
2.  **Update Client Configuration**:
    
    *   Ensure that the client's configuration matches the service's binding settings (use BasicHttpBinding with transport security).
        
3.  **Accept SSL Certificates** (Development Environment Only):
    
    ```cs
    codeSystem.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
    ```
        
4.  **Run the Client**:
    
    *   Start the client application.
        
    *   The results will be displayed upon successful service invocation.
        

Important Notes
---------------

*   **Security**:
    
    *   In production, always use SSL certificates issued by trusted Certificate Authorities.
        
    *   Do not disable SSL certificate validation in production environments.
        
*   **Port Settings**:
    
    *   The service uses port **5001** for HTTPS. Ensure this port is available and not blocked by firewalls.
        
*   **Compatibility**:
    
    *   The service uses BasicHttpBinding with transport security to maintain compatibility with older clients.
        

Summary
-------

This example provides a basic template for setting up a CoreWCF service over HTTPS and consuming it from a .NET Framework client. It highlights the key steps necessary for secure communication and demonstrates how to bridge the gap between modern and legacy .NET technologies.

References
----------

*   [CoreWCF GitHub Repository](https://github.com/CoreWCF/CoreWCF)
    
*   [Using HTTPS in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/security/enforcing-ssl)