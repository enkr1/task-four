# t4
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
### I. Access unsecure url
![](images/3.png)
Try to access unsecure http://...

### II. Automatically redirected to secure url
![](images/4.png)
Notice it has been redirected to https://...

## Inspect
![](images/5.png)
There are 2 talents methods called. 
This method get the unsecure url and return a secure url as shown below: -
![](images/6.png)

Lastly, the secure url will be used to call the GET method: -
![](images/5.png)

# Sequence Diagrams


# References:
1. https://www.youtube.com/watch?v=xIzlD-frEw4&t=183s
2. https://www.hexacta.com/How-to-enable-CORS-on-your-Web-API

