# School Patron
![School Patron Logo](/images/logo.jpg)


## BACKEND API

| Route URL       | Type           | STATUS  |
| ------------- |:-------------:| -----:|
| http://localhost:5000/patron/     | List<Patron>  | Get |
| http://localhost:5000/patron/  {id}    | Patron Get(int id)      | GET(int id) |
| http://localhost:5000/patron/ | Patron Post([FromBody]Patron p)     | POST |
| http://localhost:5000/patron/ | Patron Put (int id, [FromBody] Patron patron)     | PUT |
| http://localhost:5000/patron/ {id}  | string Delete (int id)     | DELETE |

## DATA MODEL

  ### PATRON MODEL
  public int Id { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Email { get; set; }
  public string Password { get; set; }

  ### PROJECT MODEL
  public int Id { get; set; }
  public string Name { get; set; }
  public string StartDate { get; set; }
  public string EndDate { get; set; }
  public string Subject { get; set; }
  public string GradeLevel { get; set; }
  public string Description { get; set; }
  public bool GoalReached { get; set; }
  public int? TeacherId { get; set; }
  public int? SchoolId { get; set; }
  public List<WalmartProduct> walmartProducts { get; set; }

  ### TEACHER MODEL
  public int Id { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Bio { get; set; }
  public string Email { get; set; }
  public string GradeLevel { get; set; }
  public string Password { get; set; }
  public int? SchoolId { get; set; }
  public List<Project> projects { get; set; }

  ### WALMART MODEL
  public int Id { get; set; }
  public string Name { get; set; }
  public string SalePrice { get; set; }
  public string ShortDescription { get; set; }
  public string MediumImage { get; set; }
  public string CustomerRatingImage { get; set; }
  public int? ProjectId { get; set; }
  public string AddToCartUrl { get; set; }

  