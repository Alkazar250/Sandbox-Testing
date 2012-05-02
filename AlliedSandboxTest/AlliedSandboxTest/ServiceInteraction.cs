using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using AlliedSandboxTest.ServiceReference1;

namespace AlliedSandboxTest
{
    public partial class Form1 : Form
    {
        public void getAllAuthors(TestCase tc)
        {
            try
            {
                Author[] authors = sc.GetAllAuthors();
                int count = 0;

                foreach (Author a in authors)
                {
                    TreeNode node = response.Nodes.Add(++count + ". Author: " + a.Name);
                    node.Nodes.Add("ID: " + a.AuthorID);
                    node.Nodes.Add("Flag: " + a.Flag);
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void getAuthorByName(TestCase tc)
        {
            try
            {
                Author a = sc.GetAuthor(tc.attr[0]);
                TreeNode node = response.Nodes.Add("Author: " + a.Name);
                node.Nodes.Add("ID: " + a.AuthorID);
                node.Nodes.Add("Flag: " + a.Flag);

                TreeNode result;
                if (a.AuthorID.ToString() == tc.res[0])
                {
                    result = node.Nodes.Add("Test Result: As Expected");
                    result.ForeColor = Color.Green;
                    node.ForeColor = Color.Green;
                }
                else
                {
                    result = node.Nodes.Add("Test Result: Error");
                    result.ForeColor = Color.Red;
                    node.ForeColor = Color.Red;
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void getAuthorByID(TestCase tc)
        {
            try
            {
                Author a = sc.GetAuthorID((Guid)gc.ConvertFromString(tc.attr[0]));
                TreeNode node = response.Nodes.Add("Author: " + a.Name);
                node.Nodes.Add("ID: " + a.AuthorID);
                node.Nodes.Add("Flag: " + a.Flag);

                TreeNode result;
                if (a.Name.ToString() == tc.res[0])
                {
                    result = node.Nodes.Add("Test Result: As Expected");
                    result.ForeColor = Color.Green;
                    node.ForeColor = Color.Green;
                }
                else
                {
                    result = node.Nodes.Add("Test Result: Error");
                    result.ForeColor = Color.Red;
                    node.ForeColor = Color.Red;
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void newAuthor(TestCase tc)
        {
            try
            {
                Guid id = sc.NewAuthor(tc.attr[0]);
                TreeNode node = response.Nodes.Add("Created new Author: " + tc.attr[0]);
                node.Nodes.Add("ID: " + id);

                TestCase tc1 = new TestCase();
                tc1.attr.Add(id.ToString());
                tc1.res.Add(tc.attr[0]);

                getAuthorByID(tc1);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void updateAuthor(TestCase tc)
        {
            try
            {
                sc.UpdateAuthor((Guid)gc.ConvertFromString(tc.attr[0]), tc.attr[1], tc.attr[2]);
                TreeNode node = response.Nodes.Add("Changed author Name: " + tc.attr[0]);
                node.Nodes.Add("Id: " + tc.attr[0]);
                node.Nodes.Add("Old name: " + tc.attr[1]);
                node.Nodes.Add("New name: " + tc.attr[2]);

                TestCase tc1 = new TestCase();
                tc1.attr.Add(tc.attr[0]);
                tc1.res.Add(tc.attr[2]);
                getAuthorByID(tc1);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void deleteAuthor(TestCase tc)
        {
            try
            {
                sc.DeleteAuthor((Guid)gc.ConvertFromString(tc.attr[0]));
                getAllAuthors(tc);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        public void getAllUsers(TestCase tc)
        {
            try
            {
                User[] users = sc.GetAllUsers();
                int count = 0;

                foreach (User u in users)
                {
                    TreeNode node = response.Nodes.Add(++count + ". User: " + u.UserName);
                    node.Nodes.Add("ID: " + u.UserId);
                    node.Nodes.Add("Mail: " + u.MailAddress);
                    node.Nodes.Add("Flag: " + u.Flag);
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void searchUsers(TestCase tc)
        {
            try
            {
                KeyValue[] kv = new KeyValue[1];
                kv[0] = new KeyValue();
                kv[0].Key = tc.attr[0];
                kv[0].Value = tc.attr[1];

                User[] users = sc.Search_Users(kv);
                int count = 0;

                foreach (User u in users)
                {
                    TreeNode node = response.Nodes.Add(++count + ". User: " + u.UserName);
                    node.Nodes.Add("ID: " + u.UserId);
                    node.Nodes.Add("Mail: " + u.MailAddress);
                    node.Nodes.Add("Flag: " + u.Flag);

                    TreeNode result;
                    if (u.UserId.ToString() == tc.res[0])
                    {
                        result = node.Nodes.Add("Test Result: As Expected");
                        result.ForeColor = Color.Green;
                        node.ForeColor = Color.Green;
                    }
                    else
                    {
                        result = node.Nodes.Add("Test Result: Error");
                        result.ForeColor = Color.Red;
                        node.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void getUser(TestCase tc)
        {
            try
            {
                User user = sc.GetUser((Guid)gc.ConvertFromString(tc.attr[0]));

                TreeNode node = response.Nodes.Add("User: " + user.UserName);
                node.Nodes.Add("ID: " + user.UserId);
                node.Nodes.Add("Mail: " + user.MailAddress);
                node.Nodes.Add("Flag: " + user.Flag);

                TreeNode result;
                if (user.UserName == tc.res[0])
                {
                    result = node.Nodes.Add("Test Result: As Expected");
                    result.ForeColor = Color.Green;
                    node.ForeColor = Color.Green;
                }
                else
                {
                    result = node.Nodes.Add("Test Result: Error");
                    result.ForeColor = Color.Red;
                    node.ForeColor = Color.Red;
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void newUser(TestCase tc)
        {
            try
            {
                Guid id = sc.CreateUser(tc.attr[0], tc.attr[1], tc.attr[2]);
                TreeNode node = response.Nodes.Add("Created new User: " + tc.attr[0]);
                node.Nodes.Add("ID: " + id);
                node.Nodes.Add("pass: " + tc.attr[1]);
                node.Nodes.Add("mail: " + tc.attr[2]);

                TestCase tc1 = new TestCase();
                tc1.attr.Add("UserName");
                tc1.attr.Add(tc.attr[0]);
                tc1.res.Add(id.ToString());
                searchUsers(tc1);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void updateUser(TestCase tc)
        {
            try
            {
                sc.UpdateUser((Guid)gc.ConvertFromString(tc.attr[0]), tc.attr[1], tc.attr[2], tc.attr[3]);
                TestCase tc1 = new TestCase();
                tc1.attr.Add("UserName");
                tc1.attr.Add(tc.attr[1]);
                tc1.res.Add(tc.attr[0]);
                searchUsers(tc1);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void updateUserName(TestCase tc)
        {
            try
            {
                sc.UpdateUserName((Guid)gc.ConvertFromString(tc.attr[0]), tc.attr[1]);
                TestCase tc1 = new TestCase();
                tc1.attr.Add("UserName");
                tc1.attr.Add(tc.attr[1]);
                tc1.res.Add(tc.attr[0]);
                searchUsers(tc1);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void updateUserAddress(TestCase tc)
        {
            try
            {
                sc.UpdateUserAddress((Guid)gc.ConvertFromString(tc.attr[0]), tc.attr[1]);
                TestCase tc1 = new TestCase();
                tc1.attr.Add("MailAddress");
                tc1.attr.Add(tc.attr[1]);
                tc1.res.Add(tc.attr[0]);
                searchUsers(tc1);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void updateUserInterests(TestCase tc)
        {
            try
            {
                sc.UpdateUserInterests((Guid)gc.ConvertFromString(tc.attr[0]), tc.attr[1]);
                TestCase tc1 = new TestCase();
                tc1.attr.Add("MailAddress");
                tc1.attr.Add(tc.attr[1]);
                tc1.res.Add(tc.attr[0]);
                searchUsers(tc1);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void deleteUser(TestCase tc)
        {
            try
            {
                sc.DeleteUser((Guid)gc.ConvertFromString(tc.attr[0]));
                getAllUsers(tc);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void authUser(TestCase tc)
        {
            try
            {
                Guid id = sc.AuthenticateUser(tc.attr[0], tc.attr[1]);
                TreeNode node = response.Nodes.Add("User: " + tc.attr[0]);
                node.Nodes.Add("ID: " + id);

                TreeNode result;
                if (id.ToString() == tc.res[0])
                {
                    result = node.Nodes.Add("Test Result: As Expected");
                    result.ForeColor = Color.Green;
                    node.ForeColor = Color.Green;
                }
                else
                {
                    result = node.Nodes.Add("Test Result: Error");
                    result.ForeColor = Color.Red;
                    node.ForeColor = Color.Red;
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void recoverPassword(TestCase tc)
        {
            try
            {
                string pass = sc.RecoverPassword(tc.attr[0], tc.attr[1]);
                TreeNode node = response.Nodes.Add("User: " + tc.attr[0]);
                node.Nodes.Add("mail: " + tc.attr[1]);
                node.Nodes.Add("pass: " + pass);

                TreeNode result;
                if (pass == tc.res[0])
                {
                    result = node.Nodes.Add("Test Result: As Expected");
                    result.ForeColor = Color.Green;
                    node.ForeColor = Color.Green;
                }
                else
                {
                    result = node.Nodes.Add("Test Result: Error");
                    result.ForeColor = Color.Red;
                    node.ForeColor = Color.Red;
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        public void getAllBooks(TestCase tc)
        {
            try
            {
                Book[] books = sc.FindBooks();
                int count = 0;

                foreach (Book b in books)
                {
                    TreeNode node = response.Nodes.Add(++count + ". Book: " + b.Name);
                    node.Nodes.Add("ID: " + b.BookId);
                    node.Nodes.Add("Author: " + b.BookAuthor.Name);
                    node.Nodes.Add("Date: " + b.Year);
                    node.Nodes.Add("Type: " + b.Type);
                    node.Nodes.Add("Usage: " + b.Usage);
                    node.Nodes.Add("InLibrary: " + b.InLibrary);
                    node.Nodes.Add("Flag: " + b.Flag);
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void getBook(TestCase tc)
        {
            try
            {
                Book book = sc.GetBook((Guid)gc.ConvertFromString(tc.attr[0]));

                TreeNode node = response.Nodes.Add("Book: " + book.Name);
                node.Nodes.Add("ID: " + book.BookId);
                node.Nodes.Add("Author: " + book.BookAuthor.Name);
                node.Nodes.Add("Date: " + book.Year);
                node.Nodes.Add("Type: " + book.Type);
                node.Nodes.Add("Usage: " + book.Usage);
                node.Nodes.Add("InLibrary: " + book.InLibrary);
                node.Nodes.Add("Flag: " + book.Flag);

                TreeNode result;
                if (book.Name.ToString() == tc.res[0])
                {
                    result = node.Nodes.Add("Test Result: As Expected");
                    result.ForeColor = Color.Green;
                    node.ForeColor = Color.Green;
                }
                else
                {
                    result = node.Nodes.Add("Test Result: Error");
                    result.ForeColor = Color.Red;
                    node.ForeColor = Color.Red;
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void searchBooks(TestCase tc)
        {
            try
            {
                KeyValue[] kv = new KeyValue[1];
                kv[0] = new KeyValue();
                kv[0].Key = tc.attr[0];
                kv[0].Value = tc.attr[1];
                Book[] books = sc.Search_Books(kv);
                int count = 0;

                foreach (Book b in books)
                {
                    TreeNode node = response.Nodes.Add(++count + ". Book: " + b.Name);
                    node.Nodes.Add("ID: " + b.BookId);
                    node.Nodes.Add("Author: " + b.BookAuthor.Name);
                    node.Nodes.Add("Date: " + b.Year);
                    node.Nodes.Add("Type: " + b.Type);
                    node.Nodes.Add("Usage: " + b.Usage);
                    node.Nodes.Add("InLibrary: " + b.InLibrary);
                    node.Nodes.Add("Flag: " + b.Flag);
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void newBook(TestCase tc)
        {
            try
            {
                Guid id = sc.NewBook(tc.attr[0], tc.attr[1], DateTime.Parse(tc.attr[2]), tc.attr[3]);
                TreeNode node = response.Nodes.Add("Created new Book: " + tc.attr[0]);

                TestCase tc1 = new TestCase();
                tc1.attr.Add(id.ToString());
                tc1.res.Add(tc.attr[0]);
                getBook(tc1);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void updateBook(TestCase tc)
        {
            try
            {
                sc.UpdateBook((Guid)gc.ConvertFromString(tc.attr[0]), tc.attr[1], tc.attr[2], DateTime.Parse(tc.attr[3]));
                TreeNode node = response.Nodes.Add("Updated Book: " + tc.attr[0]);

                TestCase tc1 = new TestCase();
                tc1.attr.Add(tc.attr[0]);
                tc1.res.Add(tc.attr[1]);
                getBook(tc1);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void deleteBook(TestCase tc)
        {
            try
            {
                sc.DeleteBook((Guid)gc.ConvertFromString(tc.attr[0]));
                getAllBooks(tc);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        public void getAllTransactions(TestCase tc)
        {
            try
            {
                UsageTransaction[] tr;
                int count = 0;
                if (tc.attr.Count == 0) tr = sc.GetAllTransactions();
                else tr = sc.GetAllTransactionsByBookID((Guid)gc.ConvertFromString(tc.attr[0]));

                foreach (UsageTransaction ut in tr)
                {
                    TreeNode node = response.Nodes.Add(++count + ". Transaction");
                    node.Nodes.Add("Id: " + ut.TransactionId);
                    node.Nodes.Add("BookId: " + ut.Book);
                    node.Nodes.Add("UserId: " + ut.User);
                    node.Nodes.Add("StartDate: " + ut.StartDate);
                    node.Nodes.Add("EndDate: " + ut.EndDate);
                    node.Nodes.Add("Usage: " + ut.BookUsage);
                    node.Nodes.Add("Comment: " + ut.Comment);
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void getTransaction(TestCase tc)
        {
            try
            {
                UsageTransaction ut = sc.GetTransaction((Guid)gc.ConvertFromString(tc.attr[0]));

                TreeNode node = response.Nodes.Add("Transaction");
                node.Nodes.Add("Id: " + ut.TransactionId);
                node.Nodes.Add("BookId: " + ut.Book);
                node.Nodes.Add("UserId: " + ut.User);
                node.Nodes.Add("StartDate: " + ut.StartDate);
                node.Nodes.Add("EndDate: " + ut.EndDate);
                node.Nodes.Add("Usage: " + ut.BookUsage);
                node.Nodes.Add("Comment: " + ut.Comment);
                if (tc.res.Count != 0)
                {
                    TreeNode result;
                    if (ut.Book.ToString() == tc.res[1] && ut.User.ToString() == tc.res[0])
                    {
                        result = node.Nodes.Add("Test Result: As Expected");
                        result.ForeColor = Color.Green;
                        node.ForeColor = Color.Green;
                    }
                    else
                    {
                        result = node.Nodes.Add("Test Result: Error");
                        result.ForeColor = Color.Red;
                        node.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void searchTransactions(TestCase tc)
        {
            try
            {
                KeyValue[] kv = new KeyValue[1];
                kv[0] = new KeyValue();
                kv[0].Key = tc.attr[0];
                kv[0].Value = tc.attr[1];
                UsageTransaction[] tr = sc.Search_Transactions(kv);
                int count = 0;

                foreach (UsageTransaction ut in tr)
                {
                    TreeNode node = response.Nodes.Add(++count + ". Transaction");
                    node.Nodes.Add("Id: " + ut.TransactionId);
                    node.Nodes.Add("BookId: " + ut.Book);
                    node.Nodes.Add("UserId: " + ut.User);
                    node.Nodes.Add("StartDate: " + ut.StartDate);
                    node.Nodes.Add("EndDate: " + ut.EndDate);
                    node.Nodes.Add("Usage: " + ut.BookUsage);
                    node.Nodes.Add("Comment: " + ut.Comment);
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void newTransaction(TestCase tc)
        {
            try
            {
                Guid id = sc.NewTransaction((Guid)gc.ConvertFromString(tc.attr[0]), (Guid)gc.ConvertFromString(tc.attr[1]),
                    DateTime.Parse(tc.attr[2]), DateTime.Parse(tc.attr[3]), tc.attr[4]);
                TreeNode node = response.Nodes.Add("Created new Transaction: " + tc.attr[0]);

                TestCase tc1 = new TestCase();
                tc1.attr.Add(id.ToString());
                tc1.res.Add(tc.attr[0]);
                tc1.res.Add(tc.attr[1]);
                getTransaction(tc);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void updateTransaction(TestCase tc)
        {
            try
            {
                sc.UpdateTransaction((Guid)gc.ConvertFromString(tc.attr[0]), Int16.Parse(tc.attr[1]), tc.attr[2]);
                TreeNode node = response.Nodes.Add("Created new Transaction: " + tc.attr[0]);

                TestCase tc1 = new TestCase();
                tc1.attr.Add(tc.attr[0]);
                getTransaction(tc);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void updateTransactionInLibrary(TestCase tc)
        {
            try
            {
                sc.UpdateTransactionInLibrary((Guid)gc.ConvertFromString(tc.attr[0]), DateTime.Parse(tc.attr[1]));
                TreeNode node = response.Nodes.Add("Created new Transaction");
                node.Nodes.Add("Id: " + tc.attr[0]);

                TestCase tc1 = new TestCase();
                tc1.attr.Add(tc.attr[0]);
                getTransaction(tc);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        public void deleteTransaction(TestCase tc)
        {
            try
            {
                sc.DeleteTransaction((Guid)gc.ConvertFromString(tc.attr[0]));
                TreeNode node = response.Nodes.Add("Deleted Transaction");
                node.Nodes.Add("Id: " + tc.attr[0]);

                TestCase tc1 = new TestCase();
                tc1.attr.Add(tc.attr[0]);
                getTransaction(tc);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
               
    }
}
