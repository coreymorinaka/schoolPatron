using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("teacher")]
    public class TeacherController : Controller
    {
        private readonly SchoolPatronContext _context;
        public int teacherId = 21; 
        
        public TeacherController (SchoolPatronContext context)
        {
            _context = context;
            if(_context.teachers.Count() == 0)
            {

              _context.teachers.Add(new Teacher() {Id = 1, FirstName = "Corey", LastName = "Morinaka", Bio ="Back-End Web Developer and teacher", Email="sp@basepod.com", GradeLevel="8"});
              _context.teachers.Add(new Teacher() {Id = 2, FirstName="David", LastName="Kayo", Bio="Full-Stack Developer and teacher", Email="sp@basepod.com", GradeLevel="12"});
              _context.teachers.Add(new Teacher() {Id = 3, FirstName="Sally", LastName="Puri", Bio="Your donation will make my students Happy as they will be able to decipher hidden codes, visualize intrinsic patterns, solve challenging puzzles and also create their own . I want my students to get a solid grasp of thinking critically to solve realistic problems and find applicable solutions. I am trying my utmost to enhance their abilities and make studying worthwhile but I do not have the necessary materials to provide enrichment/acceleration to my students who are hungry for exchanging ideas, find solutions, creating amazing things and being recognized! I know for sure once optimally engaged my students will begin to 'own' their learning and totally energized they will certainly accomplish more academically. By internalizing high standards they will begin expecting wonderful things out of themselves. Your help matters in building their character and self-esteem. A sparkling group awaits your generous help!", Email="spuri@benfranklin.com", GradeLevel="4"});
              _context.teachers.Add(new Teacher() {Id = 4, FirstName="Liev", LastName="Schreiber", Bio="Students in primary grades need hands on materials to make learning more engaging. Building words is an important part of reading success. Getting these materials into their hands is very important. My students are eager to learn, and I am excited to see how far they can go as readers this school year. By manipulating magnetic letters on the individual whiteboards, they will build words and vocabulary. Right now we are using plain paper letters. Having fun and useful materials make learning more engaging. Please help me to supply these items for my students. Thank you for taking the time to consider my project!", Email="lschreiber@arsenal.com", GradeLevel="3"});
              _context.teachers.Add(new Teacher() {Id = 5, FirstName="Tina", LastName="Vora", Bio="Welcome to my page! I'm a high school ELA teacher who is currently in my 6th year of teaching. I transitioned from a career in corporate finance to public school teaching and it was, without a doubt, the best decision I have ever made in my life. I love my job and am so grateful to be teaching the leaders of tomorrow!", Email="tvora@parkslope.com", GradeLevel="12"});
              _context.teachers.Add(new Teacher() {Id = 6, FirstName="Pamela", LastName="Ciorletti", Bio="Students will be able to tell who is on their team and work together during sports. Working together during an athletic event will only enhance their abilities to work together in the classroom. My class focuses a lot on team sports and the cohesion that it builds in a particular class. Most of my students are in need of emotional support or have severe behavior issues. Wearing jerseys to have clear representation of the teams will stop many arguments before they occur. These can be used in almost every game that we play during class and will be so helpful! We would also love a volleyball for class! Volleyball is a lifetime sport and my students and I would love to begin learning this lifetime skill as soon as possible.", Email="pciorletti@samuelpennypacker.com", GradeLevel="7"});
              _context.teachers.Add(new Teacher() {Id = 7, FirstName="James", LastName="Hamilton", Bio="Cool-guy Teacher", Email="jhamilton@jamescampbell.com", GradeLevel="11"});
              _context.teachers.Add(new Teacher() {Id = 8, FirstName="Eugene", LastName="Bolda", Bio="I work with students at the elementary and high school level in Fargo,North Dakota. There is a large migrant population here which does not understand the language and culture. I will use these supplies with some of these ELL (English Language Learners), regular education students, and with my students who qualify for special education. Our students enjoy listening to stories and group activities.", Email="ebolda@roosevelt.com", GradeLevel="5"});
              _context.teachers.Add(new Teacher() {Id = 9, FirstName="Sarah", LastName="Riessen", Bio="The children at this school are amazing kids in 6th, 7th and 8th grade. As a Title I School, we have many children who come from families who experience poverty and fall on financial struggles. We want these children to have all of the tools they need to be able to learn self-expression through the arts! We have classes for both 2D and 3D art. In each class, we work to provide enriching lesson plans that examine and recreate art inspired from around the globe. I have made a 'wishlist' of some of the most commonly used items in our classroom, including supplies needed for sculpture, printmaking and painting such as canvas, paper, and watercolors. We have units on Chinese, Indian, and Native American art, amongst others! With over 170 students enrolled in the 2D and 3D art programs, having enough items for all children to participate in the activities ensures that my focus can be on their learning. We are preparing the leaders of tomorrow and connecting them to global cultures in our hopes of creating well-rounded young men and women, prepared for tomorrow's world. The art we make in our class gets displayed at school and around our community! I sincerely thank you for any support and believe each donation will make a difference in the life of a child.", Email="sriessen@southseminole.com", GradeLevel="6"});
              _context.teachers.Add(new Teacher() {Id = 10, FirstName="Lisa", LastName="Tedesco", Bio="My students are in first grade. The majority of the class qualifies for free or reduced lunch and speak a language other than English. My students are eager and ambitious in their daily work of building strong social/emotional and academic skills. Our school district is unique in that there are over 57 languages spoken.", Email="ltedesco@e2ndcommunity.com", GradeLevel="1"});
              _context.teachers.Add(new Teacher() {Id = 11, FirstName="Lillie", LastName="Chaikittirattana", Bio="Hipster Teacher", Email="lChaikittirattana@peninsula.com", GradeLevel="3"});
              _context.teachers.Add(new Teacher() {Id = 12, FirstName="Linda", LastName="Brown", Bio="I teach a group of beautiful babies ranging in various disabilities in a low income community. I love my bunch! Our schools motto is 'Hard Work Conquers all' as we strive to improve academic achievement due to its low ratings. I am not only honored to be apart of the standards set for our scholars but I can only anticipate how great they will become.", Email="lbrown@anniewebb.com", GradeLevel="PreK"});
              _context.teachers.Add(new Teacher() {Id = 13, FirstName="Jennifer", LastName="Egbert", Bio="I teach students at a K-8 Charter School located in Las Vegas. They are in love with STEM lessons. They look forward to learning and creating something new each week. At our school, we teach our students all aspects of STEM. We teach them the engineering design process, how to explore, create, test, design and improve.", Email="jegbert@pinecrest.com", GradeLevel="4"});
              _context.teachers.Add(new Teacher() {Id = 14, FirstName="Myrtle", LastName="Brackett", Bio="My class is a Title I Preschool class in a large urban setting. My students come from economically disadvantaged homes. The majority of students were non-English speaking when they entered school. Our program provides developmentally appropriate experiences for children with an emphasis on learning through hands-on engagement.", Email="mbrackett@johnbennet.com", GradeLevel="K"});
              _context.teachers.Add(new Teacher() {Id = 15, FirstName="Grace", LastName="McNulty", Bio="I am requesting Camelbak water bottles to help hydrate my students. Staying hydrated is very important for students to stay focused during the school day. Our team is working on purchasing a water fountain with a water bottle filling station for our students to use. With this station installed in the 8th grade hallway the students in our building will be able to quickly fill up their water bottle in order to take it to class and hydrate throughout the day. This will allow students to make healthy choices and learn about taking care of our earth. All basic needs must be met for students before they can focus and learn. Knowing this, we hope to help provide water bottles for students to fill and utilize during their long days at school. We are excited to have students that are engaged because their basic need of hydration is met.We know that when students are ready to learn they will be more successful.", Email="gmcnulty@cymiddle.com", GradeLevel="7"});
              _context.teachers.Add(new Teacher() {Id = 16, FirstName="Marsha", LastName="Elias", Bio="Having access to their own book will allow my students to be able to find evidence in the text, annotate and read daily. Without a text to read, they are forced to rely on worksheets and handouts as their only reading material in the classroom. 'I am Malala' is a biographical book that will help the students connect to bigger ideas we are studying in class and will tie directly to standards based learning in 6th grade. Within this unit we will be exploring author's viewpoint, how an author's experiences contribute to the text and connecting it to other informational readings from various authors.", Email="melias@nuview.com", GradeLevel="6"});
              _context.teachers.Add(new Teacher() {Id = 17, FirstName="Georgina", LastName="Mattox", Bio="Meet the students of the Tiger Band! They are made up of determined individuals who love to create music, and have a good time working together. Our school is a 4A school located in a rural county, rich with history and tradition. History and tradition are important to the Tiger Band, because of it's HUGE history. The Band program was once 150+ strong! We are working together to achieve that standard of excellence. Over the past two years, the MCHS Tiger Band has worked to improve their scores an average of 20 points! The program now includes 6th graders, which has allowed our overall program size increase by 20. We are very excited to be experiencing this growth, we do appreciate any help or support that can help the MCHS Band Program be the best it can be!", Email="gmattox@monroe.com", GradeLevel="11"});
              _context.teachers.Add(new Teacher() {Id = 18, FirstName="Peyton", LastName="Manring", Bio="My classroom is a self-contained classroom for students with moderate to severe disabilities. My students range in age from 14 years to 21 years old. We currently have a student population of 15 amazing students with diverse learning needs working on functional academics, adaptive/life tasks, social skills, transition skills for adult living, and job training. Our school is a low income high migrant population school, so my students come from a high variety of backgrounds and home situations, but they come to school and light up the classroom with their smiles and laughter. Every student in this class has their own set of struggles and difficulties, but they all work their hardest to overcome these to become independent young adults. These students never fail to amaze and surprise me every day.", Email="pmanring@toppenish.com", GradeLevel="12"});
              _context.teachers.Add(new Teacher() {Id = 19, FirstName="Josh", LastName="Specht", Bio="Due to our High School being an Engineering Academy, many of the students are working in classes that work collaboratively across many different subjects. By adding the Raspberry Pi Bulletin Board in our school, students will be able to see what is happening in not just our class, but also what is taking place across the school at a glance. Students will be able to see due dates, upcoming assessments, and events like visiting speakers or project presentations, a collage of student photos, and important school announcements. The Raspberry Pi can be incorporated into class projects as well. Students will be able to edit the bulletin board so it will display the events and announcements. They will also use appropriate probes and sensors with the raspberry pi to collect and display data such as the local temperature and weather conditions.", Email="jspecht@herscheljenkins.com", GradeLevel="10"});
              _context.teachers.Add(new Teacher() {Id = 20, FirstName="Taylor", LastName="Sizemore", Bio="We are a class in a small school (about 125 students K-12), in a small Alaskan village. The students love to fish, hunt, pick berries, and explore the tundra. We either walk to school or get a ride on an ATV. We work hard in school and play hard outside of school. The school provides the necessary supplies for learning the major subjects (not including art and music). However, getting new or unique supplies is a challenge given budget and our remote setting.", Email="tsizemore@chiefivanblunka.com", GradeLevel="3"});
              _context.teachers.Add(new Teacher() {Id = 21, FirstName="Mary", LastName="Nivanh", Bio="These bands will be used to help students stay focused and allow movement while at their seats. These bands can be used as a foot rest for those students that are not as tall. These bands will help support student posture and concentration. These bands are often used and seen in OT/PT specialized class and services. With this being said, these tools can be used to help students with ADHD, lower stress & anxiety, and increase productivity. Students need a lot of movement throughout the day and these bands give students the chance to move even while working, which stimulate the brain.", Email="mnivanh@whittier.com", GradeLevel="1"});
              _context.teachers.Add(new Teacher() {Id = 22, FirstName="Alan", LastName="Chen", Bio="My students are creative, well-behaved, fun and filled with potential! My students are attending a Boston Public School, in which they are all qualified for free lunch. They are a diverse group of students, and a few of them have Individual Educational Plans, in which they require differentiated learning. However, they are all performing really great and they have strong work ethic!", Email="achen@quincyupper.com", GradeLevel="8"});
              _context.teachers.Add(new Teacher() {Id = 23, FirstName="David", LastName="Kayo", Bio="", Email="@.com", GradeLevel="12"});
              _context.teachers.Add(new Teacher() {Id = 24, FirstName="David", LastName="Kayo", Bio="", Email="@.com", GradeLevel="12"});
              _context.teachers.Add(new Teacher() {Id = 25, FirstName="David", LastName="Kayo", Bio="", Email="@.com", GradeLevel="12"});
              _context.SaveChanges();
            }
        }
        // GET
        [HttpGet]
        public List<Teacher> Get ()
        {
            return _context.teachers.ToList ();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Teacher Get(int id)
        {
            foreach (Teacher t in _context.teachers)
            {
                if (t.Id == id)
                {
                    return t;
                }
            }
            return null;
        }
        

        // POST api/values
        [HttpPost]
        public Teacher Post([FromBody]Teacher t)
        {
            t.Id = teacherId++;
            _context.teachers.Add(t);
            _context.SaveChanges();

            return t;
        }

        // PUT api/values/5
        [HttpPut ("{id}")]
        public Teacher Put (int id, [FromBody] Teacher teacher)
        {
            foreach (Teacher t in _context.teachers)
            {
                if (t.Id == id)
                {
                    _context.teachers.Remove (t);
                    _context.SaveChanges ();
                    _context.teachers.Add (teacher);
                    _context.SaveChanges ();

                    return teacher;
                }
            }
            return null;
        }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public string Delete (int id)
        {
            foreach(Teacher t in _context.teachers)
            {
                if(t.Id == id)
                {
                    _context.teachers.Remove(t);
                    _context.SaveChanges();
                    return "deleted";
                }
            }
            return "not found";
        }
    }
}
