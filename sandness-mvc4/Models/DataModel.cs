using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sandness_mvc4.Models
{
    [Table("Customer")]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone  { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string OrganizationNumber { get; set; }
        public DateTime Created { get; set; }
    }


    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile  { get; set; }
        public int UserGroupId { get; set; }
        public int RollId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Create { get; set; }
        public DateTime LastLogin { get; set; }
       
    }
    [Table("Order")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int UserId {get; set;}
        public int CustomerId { get; set; }
        public int ProjectId { get; set; }
        public String DeliveryDate { get; set; }
        public string  DeliveryTime { get; set; }
        public string Lmin { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public int Deleted { get; set; }
        public DateTime Created { get; set; }
        
    }
    [Table("Orderval")]
    public class Orderval
    {
        public int id { get; set; }
        public int OrderId { get; set; }                
        public int Felt { get; set; }
        public string Choice { get; set; }
    }
    [Table("Project")]
    public class Project
	{
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City  { get; set; }
        public string Projectnumber { get; set; }
        public DateTime Created { get; set; }		
	}
    [Table("ProjectsEmail")]
    public class ProjectsEmail
    {
        public int Id { get; set; }        
        public int ProjectId { get; set; }
        public string Email { get; set; }
        public DateTime created { get; set; }
    }
    [Table("Roll")]
    public class Roll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int New { get; set; }
        public int Edit { get; set; }
        public DateTime Created { get; set; }
    }
   
    [Table("Infopages") ]
    public class Infopages
	{
        public int Id { get; set; }        
        public string Text { get; set; }
	}
    [Table("Textcodes")]
    public class Textcodes
    {
        public int Id { get; set; }
        public string t_val { get; set; }
        public int  InfopagesId { get; set; }
        public int Ord { get; set; }
        public DateTime Created { get; set; }
        //public virtual ICollection<Infopages> Infopages { get; set; }
    }
    [Table("Felters")]
    public class Felters
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public int Ord { get; set; }
        public int ForUser { get; set; }
        public int ForTable { get; set; }
    }
    [Table("Choices")]
    public class Choices
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FeltId { get; set; }
        public DateTime Created { get; set; }
        public int Default { get; set; }
        public int Ord { get; set; }
    }
    [Table ("Dropdowns")]
    public class Dropdowns
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Did { get; set; }
        public DateTime Created { get; set; }
        public int Ord { get; set; }
        public int Default { get; set;}

    }

}