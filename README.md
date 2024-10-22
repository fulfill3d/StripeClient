
# StripeClient

StripeClient is a .NET library that integrates with Stripe's payment gateway, providing support for managing customers, payment methods, setup intents, and payment intents. It leverages the official Stripe .NET SDK and includes AutoMapper profiles for mapping data between Stripe's models and your application's domain.

## Table of Contents

1. [Introduction](#introduction)
2. [Features](#features)
3. [Tech Stack](#tech-stack)
4. [Usage](#usage)
5. [Configuration](#configuration)

## Introduction

StripeClient simplifies payment integration by offering dedicated clients for handling customer setup, payment methods, and payment processing through Stripe. It supports configuring API keys securely and integrates AutoMapper to simplify the mapping of data between the Stripe SDK and your application.

## Features

- **Payment Intent Client:** Allows you to create, retrieve, and confirm payment intents.
- **Payment Setup Clients:** Manages customers, payment methods, and setup intents.
- **AutoMapper Support:** Integrates AutoMapper to handle model mapping.
- **API Key Configuration:** Supports secure configuration of Stripe API keys.

## Tech Stack

- **Backend:** .NET 8
- **Payment Gateway:** Stripe .NET SDK
- **Mapping:** AutoMapper
- **Dependency Injection:** Used for service registrations and configurations

## Usage

1. **Register the StripeClient:** Use the provided extension methods such as `AddStripePaymentIntentClient` or `AddStripeSetupPaymentClients` to register the necessary clients in the dependency injection container.
2. **Configure API Keys:** Use the `StripeClientOptions` class to set up the Stripe API key.
3. **Invoke Services:** Use the respective service clients (e.g., `IPaymentIntentClient`, `ICustomerClient`) to interact with Stripe's API.

## Configuration

### StripeClientOptions

- **ApiKey:** The API key for authenticating requests to Stripe.

```csharp
public class StripeClientOptions
{
    public string ApiKey { get; set; }
}
```

### Dependency Injection Example

Registering Stripe clients and configuring options in the `Startup.cs` or `Program.cs`:

```csharp
services.AddStripePaymentIntentClient(options =>
{
    options.ApiKey = "your-stripe-api-key";
});

services.AddStripeSetupPaymentClients(options =>
{
    options.ApiKey = "your-stripe-api-key";
});
```
