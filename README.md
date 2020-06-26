# task-four
Pang Jing Hui | P1845259 

## Web API Document
| No. | HTTP Method  | Route | Description |
| ------------- | ------------- | ------------- | ------------- |
| 1. | GET | api/talents | Retrieve all the data.  |
| 2. | GET | api/talents/{id:int} | Retrieve data based on id. Route constraints let you restrict how the parameters in the route template are matched. The general syntax is "{parameter:constraint}". |

# Postman testing screenshots:
### 1. GET - Retrieve all talents
![](images/1.png)

### 2. GET - Retrieve talent by id
![](images/2.png)

# HTTP to HTTPS testing screenshots:
### 1. Access unsecure url
![](images/3.png)
Try to access unsecure http://...

### 2. Automatically redirected to secure url
![](images/4.png)
Notice it has been redirected to https://...

## Inspect
![](images/5.png)
There are 2 talents methods called. 
This method get the unsecure url and return a secure url as shown below: -
![](images/6.png)

Lastly, the secure url will be used to call the GET method: -
![](images/5.png)

# Network failure catch:
## 1. Network failed
![](images/n1.png)
For debugging purpose, console will show the message, "Event: Offline; Status: offline", when the network is disconnected. 
The "Offline" message will be shown on top and the "Retry" button will be showned at the top right for user to refresh the browser.

## 2. Network reconnected
![](images/n2.png)
The "Online" message will be shown on top and the "Retry" button will disappear.

# Sequence Diagrams
### 1. Unsecure Talent Search Web API
![](images/sd.jpeg)

### 2. Secure Talent Search Web API
![](images/sd2.jpeg)
Note: RequireHttpsAttribute class overwrite AuthorizationFilterAttribute class as implementing if else statement to detect if the url is http or https.

# References:
1. https://www.youtube.com/watch?v=xIzlD-frEw4
2. https://www.hexacta.com/How-to-enable-CORS-on-your-Web-API
3. https://developer.mozilla.org/en-US/docs/Web/API/NavigatorOnLine/Online_and_offline_events
