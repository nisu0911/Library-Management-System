﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LibraryMSEntities : DbContext
    {
        public LibraryMSEntities()
            : base("name=LibraryMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblBook> tblBooks { get; set; }
        public virtual DbSet<tblLibrarian> tblLibrarians { get; set; }
        public virtual DbSet<tblStock> tblStocks { get; set; }
        public virtual DbSet<tblStudent> tblStudents { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
    
        public virtual int addBook(string author, string bookName, string isbn, byte[] photo, string isReference, string addedDate)
        {
            var authorParameter = author != null ?
                new ObjectParameter("author", author) :
                new ObjectParameter("author", typeof(string));
    
            var bookNameParameter = bookName != null ?
                new ObjectParameter("bookName", bookName) :
                new ObjectParameter("bookName", typeof(string));
    
            var isbnParameter = isbn != null ?
                new ObjectParameter("isbn", isbn) :
                new ObjectParameter("isbn", typeof(string));
    
            var photoParameter = photo != null ?
                new ObjectParameter("photo", photo) :
                new ObjectParameter("photo", typeof(byte[]));
    
            var isReferenceParameter = isReference != null ?
                new ObjectParameter("isReference", isReference) :
                new ObjectParameter("isReference", typeof(string));
    
            var addedDateParameter = addedDate != null ?
                new ObjectParameter("addedDate", addedDate) :
                new ObjectParameter("addedDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addBook", authorParameter, bookNameParameter, isbnParameter, photoParameter, isReferenceParameter, addedDateParameter);
        }
    
        public virtual int addStock(Nullable<int> bookID, Nullable<int> quantity)
        {
            var bookIDParameter = bookID.HasValue ?
                new ObjectParameter("bookID", bookID) :
                new ObjectParameter("bookID", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addStock", bookIDParameter, quantityParameter);
        }
    
        public virtual int addStudent(string fullName, string gender, string rollNo, string phoneNo, string email, string photo)
        {
            var fullNameParameter = fullName != null ?
                new ObjectParameter("FullName", fullName) :
                new ObjectParameter("FullName", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var rollNoParameter = rollNo != null ?
                new ObjectParameter("RollNo", rollNo) :
                new ObjectParameter("RollNo", typeof(string));
    
            var phoneNoParameter = phoneNo != null ?
                new ObjectParameter("PhoneNo", phoneNo) :
                new ObjectParameter("PhoneNo", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var photoParameter = photo != null ?
                new ObjectParameter("Photo", photo) :
                new ObjectParameter("Photo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addStudent", fullNameParameter, genderParameter, rollNoParameter, phoneNoParameter, emailParameter, photoParameter);
        }
    
        public virtual int AddUser(string username, string password, string userType, string fullName)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var userTypeParameter = userType != null ?
                new ObjectParameter("userType", userType) :
                new ObjectParameter("userType", typeof(string));
    
            var fullNameParameter = fullName != null ?
                new ObjectParameter("fullName", fullName) :
                new ObjectParameter("fullName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddUser", usernameParameter, passwordParameter, userTypeParameter, fullNameParameter);
        }
    
        public virtual int deleteBook(Nullable<int> bookID)
        {
            var bookIDParameter = bookID.HasValue ?
                new ObjectParameter("bookID", bookID) :
                new ObjectParameter("bookID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteBook", bookIDParameter);
        }
    
        public virtual int deleteStudent(Nullable<int> studentID)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteStudent", studentIDParameter);
        }
    
        public virtual int DeleteUser(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUser", userIDParameter);
        }
    
        public virtual ObjectResult<getBookByID_Result> getBookByID(Nullable<int> bookID)
        {
            var bookIDParameter = bookID.HasValue ?
                new ObjectParameter("bookID", bookID) :
                new ObjectParameter("bookID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getBookByID_Result>("getBookByID", bookIDParameter);
        }
    
        public virtual ObjectResult<getBooks_Result> getBooks()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getBooks_Result>("getBooks");
        }
    
        public virtual ObjectResult<getStock_Result> getStock(Nullable<int> bookID)
        {
            var bookIDParameter = bookID.HasValue ?
                new ObjectParameter("bookID", bookID) :
                new ObjectParameter("bookID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getStock_Result>("getStock", bookIDParameter);
        }
    
        public virtual ObjectResult<getStudent_Result> getStudent()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getStudent_Result>("getStudent");
        }
    
        public virtual ObjectResult<getStudentByID_Result> getStudentByID(Nullable<int> studentID)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getStudentByID_Result>("getStudentByID", studentIDParameter);
        }
    
        public virtual ObjectResult<GetUsers_Result> GetUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUsers_Result>("GetUsers");
        }
    
        public virtual int updateBook(Nullable<int> bookID, string author, string bookName, string isbn, string photo, string isReference, string addedDate)
        {
            var bookIDParameter = bookID.HasValue ?
                new ObjectParameter("bookID", bookID) :
                new ObjectParameter("bookID", typeof(int));
    
            var authorParameter = author != null ?
                new ObjectParameter("author", author) :
                new ObjectParameter("author", typeof(string));
    
            var bookNameParameter = bookName != null ?
                new ObjectParameter("bookName", bookName) :
                new ObjectParameter("bookName", typeof(string));
    
            var isbnParameter = isbn != null ?
                new ObjectParameter("isbn", isbn) :
                new ObjectParameter("isbn", typeof(string));
    
            var photoParameter = photo != null ?
                new ObjectParameter("photo", photo) :
                new ObjectParameter("photo", typeof(string));
    
            var isReferenceParameter = isReference != null ?
                new ObjectParameter("isReference", isReference) :
                new ObjectParameter("isReference", typeof(string));
    
            var addedDateParameter = addedDate != null ?
                new ObjectParameter("addedDate", addedDate) :
                new ObjectParameter("addedDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateBook", bookIDParameter, authorParameter, bookNameParameter, isbnParameter, photoParameter, isReferenceParameter, addedDateParameter);
        }
    
        public virtual int updateStock(Nullable<int> bookID, Nullable<int> quantity)
        {
            var bookIDParameter = bookID.HasValue ?
                new ObjectParameter("bookID", bookID) :
                new ObjectParameter("bookID", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateStock", bookIDParameter, quantityParameter);
        }
    
        public virtual int updateStudent(Nullable<int> studentID, string fullName, string gender, string rollNo, string phoneNo, string email, string photo)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(int));
    
            var fullNameParameter = fullName != null ?
                new ObjectParameter("FullName", fullName) :
                new ObjectParameter("FullName", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var rollNoParameter = rollNo != null ?
                new ObjectParameter("RollNo", rollNo) :
                new ObjectParameter("RollNo", typeof(string));
    
            var phoneNoParameter = phoneNo != null ?
                new ObjectParameter("PhoneNo", phoneNo) :
                new ObjectParameter("PhoneNo", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var photoParameter = photo != null ?
                new ObjectParameter("Photo", photo) :
                new ObjectParameter("Photo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateStudent", studentIDParameter, fullNameParameter, genderParameter, rollNoParameter, phoneNoParameter, emailParameter, photoParameter);
        }
    
        public virtual int UpdateUser(Nullable<int> userID, string username, string password, string userType, string fullName)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var userTypeParameter = userType != null ?
                new ObjectParameter("userType", userType) :
                new ObjectParameter("userType", typeof(string));
    
            var fullNameParameter = fullName != null ?
                new ObjectParameter("fullName", fullName) :
                new ObjectParameter("fullName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateUser", userIDParameter, usernameParameter, passwordParameter, userTypeParameter, fullNameParameter);
        }
    
        public virtual ObjectResult<verifyUser_Result> verifyUser(string username, string password, string userType)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var userTypeParameter = userType != null ?
                new ObjectParameter("userType", userType) :
                new ObjectParameter("userType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<verifyUser_Result>("verifyUser", usernameParameter, passwordParameter, userTypeParameter);
        }
    }
}