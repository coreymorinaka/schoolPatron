# School Patron



## BACKEND API

| Route URL       | Type           | STATUS  |
| ------------- |:-------------:| -----:|
| http://localhost:5000/patron/     | List<Patron>  | Get |
| http://localhost:5000/patron/  {id}    | Patron Get(int id)      | GET(int id) |
| http://localhost:5000/patron/ | Patron Post([FromBody]Patron p)     | POST |
| http://localhost:5000/patron/ | Patron Put (int id, [FromBody] Patron patron)     | PUT |
| http://localhost:5000/patron/ {id}  | string Delete (int id)     | DELETE |

## DATA MODEL

  ### Patron
  public int Id { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Email { get; set; }
  public string Password { get; set; }
