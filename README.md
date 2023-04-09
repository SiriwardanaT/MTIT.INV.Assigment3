# MTIT.INV.Assigment3

#What Is Microservices Architecture?


Microservices architecture is a service-oriented architecture (SOA) variant in which an application comprises a collection of lightweight, loosely coupled, modular services. These services can be built to execute on various platforms and independently developed, tested, deployed, and managed.

Microservices architecture can replace long-running, complicated monolithic systems requiring considerable resource and management overhead. Microservice is a word that refers to a service having a limited set of functionalities rather than referring to the length of the code used to create it.


#What Is an API Gateway?

When building microservices-based applications, an API Gateway is needed to have a central place where authentication, throttling, orchestration, etc., is implemented. Without an API Gateway in place, you might typically implement each of these in each service, and hence maintaining them for each service would be a daunting task at hand. An API Gateway decouples the service producer from its consumer, providing a security layer since you need not expose your microservices directly.

As soon as it receives a request, it breaks it into multiple requests (if needed) and then routes them to the appropriate downstream microservice. You can take advantage of an API Gateway to centralize, manage, and monitor the non-functional requirements of an application, orchestrate the cross-functional microservices, and reduce roundtrips. By managing requests consistently, an API Gateway can help reduce the latency and improve security.



#Introducing Ocelot?

In this article, we are going to use Ocelot API Gateway. It is a lightweight, open-source, scalable, and fast API Gateway based on .NET Core and specially designed for microservices architecture. Basically, it is a set of middleware designed to work with ASP.NET Core. It has several features such as routing, caching, security, rate limiting, etc.



