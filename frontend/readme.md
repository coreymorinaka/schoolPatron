# School Patron



## BACKEND API

| Route URL       | Type           | STATUS  |
| ------------- |:-------------:| -----:|
| http://localhost:5000/patron/     | List<Patron>  | Get |
| http://localhost:5000/patron/  {id}    | Patron Get(int id)      | GET(int id) |
| http://localhost:5000/patron/ | Patron Post([FromBody]Patron p)     | POST |
| http://localhost:5000/patron/ | Patron Put (int id, [FromBody] Patron patron)     | PUT |
| http://localhost:5000/patron/ {id}  | string Delete (int id)     | DELETE |

| Route URL       | Type           | STATUS  |
| ------------- |:-------------:| -----:|
| http://localhost:5000/project/     | List<Project>  | Get |
| http://localhost:5000/project/  {id}    | project Get(int id)      | GET(int id) |
| http://localhost:5000/project/ | project Post([FromBody]project p)     | POST |
| http://localhost:5000/project/ | project Put (int id, [FromBody] project project)     | PUT |
| http://localhost:5000/project/ {id}  | string Delete (int id)     | DELETE |

| Route URL       | Type           | STATUS  |
| ------------- |:-------------:| -----:|
| http://localhost:5000/project/     | List<Project>  | Get |
| http://localhost:5000/project/  {id}    | project Get(int id)      | GET(int id) |
| http://localhost:5000/project/ | project Post([FromBody]project p)     | POST |
| http://localhost:5000/project/ | project Put (int id, [FromBody] project project)     | PUT |
| http://localhost:5000/project/ {id}  | string Delete (int id)     | DELETE |

| Route URL       | Type           | STATUS  |
| ------------- |:-------------:| -----:|
| http://localhost:5000/teacher/     | List<Teacher>  | Get |
| http://localhost:5000/teacher/  {id}    | teacher Get(int id)      | GET(int id) |
| http://localhost:5000/teacher/ | teacher Post([FromBody]teacher p)     | POST |
| http://localhost:5000/teacher/ | teacher Put (int id, [FromBody] teacher teacher)     | PUT |
| http://localhost:5000/teacher/ {id}  | string Delete (int id)     | DELETE |

| Route URL       | Type           | STATUS  |
| ------------- |:-------------:| -----:|
| http://localhost:5000/walmart/     | string  | Get |
| http://localhost:5000/project/walmart     | List<WalmartProduct>     | GET |
| http://localhost:5000/project/walmart | WalmartProduct Post([FromBody]WalmartProduct p)     | POST |
| http://localhost:5000/project/walmart {id}  | string Delete (int id)     | DELETE |

## DATA MODEL

  ### Patron
  public int Id { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Email { get; set; }
  public string Password { get; set; }
