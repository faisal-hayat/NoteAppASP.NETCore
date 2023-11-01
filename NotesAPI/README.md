# Web API Interview Question
[source](https://www.youtube.com/watch?v=XStpo9VlzCI)

--- ---

## What is WebAPI

- Bussiness lofic and database operations in one place. 

--- ---

## Advantage Over WCF and Services/advantages of Web API ?

- woks using http: standard words such as get, post, put, and delete are used. 
- It is lighweight architecture, good for devices with limited bandwidth such as mobile phones, as data comes in form of json/xml. 
- Similar to MVC architecture. 
- Easy to learn, implent adn integrate. 

--- ---

## What is REST and RESTful API ?

- REST is set of rules of make a **_Web API_** so that it can easily communicate with other service. Web API is just a Service in nutshell.
- **_REST_** stands for representatial state transfer

--- ---

## REST Guidelines

- Separation of client and sever, implement both independently.
- Stateless: server will not store anything related to http request made by client. It will treat each request as new. 
- Uniform Interface: Identity of resources by URL.
- Cacheable: the cacheable constraint requires that a response should implicitly or explicitly label itself as cacheable or not. 
- Layered system i.e. should use hierarichal layers such as MVC architecture. 

--- ---

## RESTful API or System

- A Service written using REST principle is called RESTful.

--- ---

## How to Consume RESTful API in ASP.NET Core application ?

- Web API method can be consumed using **_HttpClient_** class.

--- ---

## Difference b/w WebAPI and MVC Controller.

- MVC controller is derived from Controller class and WebAPI controller is derived from Apicontroller.
- MVC controller has View Support whereas ApiController does not support Views.
```{c#}
[Route("controller")]
public HomeController: Controller{
}
```

```{c#}
[ApiController]
[Route("controller")]
public HomeController: ControllerBase{
}
```


--- ---