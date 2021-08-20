# unity-http-listener
A custom **HTTP REST webserver middleware for Unity** ( without .NET ). Build easily your REST API and communicate between your applications via HTTP Requests. ( made in Unity 2020.2.4f1, check Import in any Unity version section )
Based on an [amimaro gist](https://gist.githubusercontent.com/amimaro/10e879ccb54b2cacae4b81abea455b10/raw/e582fdbabda477eaf691b6a962cfb246274cad50/UnityHttpListener.cs)

## Features 
- [x] REST API ( **GET**, **POST**, **PUT**, **DELETE** ) AND/OR  Html Webserver
- [x] 3 Responses content types : **text/plain**, **text/html**, **application/json**
- [x] URL not found handling
- [x] Routes injection via reflection
- [x] Error handling via Exception StackTrace 
- [x] Sync & Async routes
- [x] SSL-Certificate configuration ( Check https://stackoverflow.com/questions/11403333/httplistener-with-https-support )

## Test
 - 1. Open Assets/TestScene. 
 - 2. Run the scene. 
 - 3. Open the [postman collection file joined](https://github.com/sachaamm/unity-http-listener/blob/main/UnityHttpListener.postman_collection.json) in postman. You can run requests samples via Postman. For text/html content type responses you can also use your web-browser with @GET routes.

## Configure 
Your HttpListener webserver is running under urls defined in the [http-listener-config file](https://github.com/sachaamm/unity-http-listener/blob/main/http-listener-config.json).
```json 
{"urlBases":["http://localhost:4444"]}
```

So by default, the webserver is running in localhost on the port 4444. You can use this files to setup your development/production environment as you wish.

## Integration of unity-http-listener in a Unity Project
### Does my project is a git repository ? 
 - YES : 
   - #### Does I care to get the ability to pull unity-http-listener new versions directly from my repository, avoiding to do step "Export unity-http-listener as a package", even upgrades of this repository will be very rare but I consider to use [git submodules features](https://git-scm.com/book/en/v2/Git-Tools-Submodules) is a good practice / a practice I need to use or learn ? 
     - YES : Go to "Import unity-http-listener as a submodule in a git repository"
     - NO : Go to "Import unity-http-listener in any Unity version as a package" 
 - NO : Go to "Import unity-http-listener in any Unity version as a package" 
  
 
## Import unity-http-listener as a submodule in a git repository



## Import unity-http-listener in any Unity version as a package
- You can easily import the project as a package in any Unity version with [UnityHttpListener package file](https://github.com/sachaamm/unity-http-listener/blob/main/UnityHttpListener.unitypackage) provided in the repository 
- OR 
- You can export the entire repository content as a package to be sure to get latests unity-http-listener features embedded (Check section "Export unity-http-listener as a package"). 

**IN ANY CASE :**  You will need to copy the [http-listener-config file](https://github.com/sachaamm/unity-http-listener/blob/main/http-listener-config.json). in the Assets parent folder ( at the root of your project )

## Export unity-http-listener as a package
 1. Create a Unity project in any version you want
 2. Clone this repository in the Unity project
 3. Right click on the repository main root folder ( unity-http-listener ), click export as a package, select all files in the repository.


## the Hello-World Controller Example 
```cs
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using UnityCustomHttpListener.Demo.Model;
using UnityCustomHttpListener.Scripts.Attribute;
using UnityCustomHttpListener.Scripts.Model;
using UnityCustomHttpListener.Scripts.Utility;
using UnityEngine;

[MyApiController]
    public class ExampleController
    {
        /// <summary>
        /// Hello world example
        /// </summary>
        /// Request : GET http://localhost:4444/
        /// <param name="request">The HttpListenerRequest can contains parameters, such as 
        /// QueryString parameters or objects contained in request.InputStream</param>
        /// <returns>An http response template emitting the status code 200</returns>
        [MyRestRoute("/", HttpRestMethod.GET,HttpResponseUtility.HttpResponseContentType.Html)]
        public HttpResponseTemplate HomeRoute(HttpListenerRequest request) 
        {
            // Important : The method needs to be public in order to be retrieved by reflection !!!
            string responseString = "<HTML><BODY> Hello world!</BODY></HTML>";
            return HttpResponseUtility.Ok(responseString);
        }
        
        }
```

For more examples, check the [ExampleController](https://github.com/sachaamm/unity-http-listener/blob/main/Assets/UnityCustomHttpListener/Demo/Controller/ExampleController.cs) file. For more explanations, you can also go to Controllers and Routes section



## Controllers and Routes
A controller is dispatching RestRoutes which can be HttpResponseTemplate or Task<HttpResponseTemplate>. A controller is labelled by the attrbute [MyApiController].
A controller's route is labelled by the attribute [MyRestRoute]
UnityHttpListener is injecting all controllers routes with [reflection](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/reflection) and this is why we use attributes to label routes and controllers.

## Fork me !
You can fork the repo 
    

``````
