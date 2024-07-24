using Microsoft.EntityFrameworkCore.ChangeTracking;
using NguyenKhacThanh_EFCore;
using SchoolDomain;

//using (var context = new SchoolDbContext())
//{
//    context.Database.EnsureCreated();

//    var gd1 = new Grade() { GradeName = "1st Grade" };
//    var st1 = new Student() { FirstName = "Yash", LastName = "Malhotra", Grade = gd1 };

//    context.Students.Add(st1);

//    context.SaveChanges();

//    foreach(var s in context.Students)
//    {
//        Console.WriteLine($"First Name: {s.FirstName}, Last Name: {s.LastName}");
//    }
//}

// Disconnected Student entity
var stud = new Student() { StudentId = 1, FirstName = "Bill" };

stud.LastName = "Steve";

using (var context = new SchoolDbContext())
{
    context.Update<Student>(stud);

    // or the followings are also valid
    // context.Students.Update(stud);
    // context.Attach<Student>(stud).State = EntityState.Modified;
    // context.Entry<Student>(stud).State = EntityState.Modified; 

    context.SaveChanges();
}

////EFCore - Create DbContext
////Unchanged State
//static void Main()
//{
//    using (var context = new SchoolDbContext())
//    {
//        // retrieve entity 
//        var student = context.Students.FirstOrDefault();
//        DisplayStates(context.ChangeTracker.Entries());
//    }
//}

//static void DisplayStates(IEnumerable<EntityEntry> entries)
//{
//    foreach (var entry in entries)
//    {
//        Console.WriteLine($"Entity: {entry.Entity.GetType().Name},State: { entry.State.ToString()}");
//    }
//}

////Added state
//using (var context = new SchoolDbContext())
//{
//    context.Students.Add(new Student() { FirstName = "Bill", LastName = "Gates" });

//    DisplayStates(context.ChangeTracker.Entries());
//}

////Modified Sate
//using (var context = new SchoolDbContext())
//{
//    var student = context.Students.FirstOrDefault();
//    student.LastName = "Friss";

//    DisplayStates(context.ChangeTracker.Entries());
//}

////Deleted State
//using (var context = new SchoolDbContext())
//{
//    var student = context.Students.FirstOrDefault();
//    context.Students.Remove(student);

//    DisplayStates(context.ChangeTracker.Entries());
//}

////Detached State
//var disconnectedEntity = new Student() { StudentId = 1, FirstName = "Bill" };

//using (var context = new SchoolDbContext())
//{
//    Console.Write(context.Entry(disconnectedEntity).State);
//}