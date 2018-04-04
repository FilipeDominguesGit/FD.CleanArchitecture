---
layout: default
---
# Interactors / Use Cases

The software in this layer contains application specific business rules. It encapsulates and implements all of the use cases of the system. These use cases orchestrate the flow of data to and from the entities, and direct those entities to use their enterprise wide business rules to achieve the goals of the use case.

We do not expect changes in this layer to affect the entities. We also do not expect this layer to be affected by changes to externalities such as the database, the UI, or any of the common frameworks. This layer is isolated from such concerns.

We do, however, expect that changes to the operation of the application will affect the use-cases and therefore the software in this layer. If the details of a use-case change, then some code in this layer will certainly be affected.


```csharp
 public interface IInteractor<in TRequest,TResponse> : IInputBoundary<TRequest> where TRequest : IRequest where TResponse : IResponse
{
    IOutputBoundary<TResponse> OutputBoundary { get; set; }
}

```

An interactor should implement the `input boundary` and contain a reference for the interface of the `output boundary`. The responsability of the implementation of the `output boundary` is to transform the `response model` into a `view model` to be used by the view. 
The `output boundary` interface (IOutputBoundary on my project) should be implemented on the `interface adapters` layer.

[back](./)