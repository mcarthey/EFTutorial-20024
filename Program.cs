using EFTutorial_20024.Models;

namespace EFTutorial_20024
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program starting");

            // C R U D

            // CREATE a blog 
            //using (var context = new BlogContext())
            //{
            //    Console.WriteLine("Enter a blog name");
            //    var blogName = Console.ReadLine();

            //    var blog = new Blog();
            //    blog.Name = blogName;

            //    context.Blogs.Add(blog);
            //    context.SaveChanges();

            //}

            // READ the Blogs
            using (var context = new BlogContext())
            {
                var blogsList = context.Blogs.ToList();

                Console.WriteLine("The blogs are:");
                foreach (var blog in blogsList)
                {
                    Console.WriteLine($"   {blog.Name}");
                }
            }

            //// UPDATE the blog
            //using (var context = new BlogContext())
            //{
            //    var blogToUpdate = context.Blogs.Where(b => b.BlogId == 1).First();

            //    Console.WriteLine($"Your choice is {blogToUpdate.Name}");
            //    Console.WriteLine("What do you want the name to be?");
            //    var updatedName = Console.ReadLine();

            //    blogToUpdate.Name = updatedName;
            //    context.SaveChanges();
            //}

            // CREATE a Post
            //using (var context = new BlogContext())
            //{
            //    Console.WriteLine("Enter a post title");
            //    var title = Console.ReadLine();
            //    Console.WriteLine("Enter post content");
            //    var content = Console.ReadLine();
            //    Console.WriteLine("Which blog?");
            //    var blogId = Console.ReadLine();

            //    var post = new Post();
            //    post.Title = title;
            //    post.Content = content;
            //    post.BlogId = Convert.ToInt32(blogId);

            //    context.Posts.Add(post);
            //    context.SaveChanges();
            //}

            // READ the posts
            using (var context = new BlogContext())
            {
                var postsList = context.Posts.ToList();

                Console.WriteLine("The posts are:");
                foreach (var post in postsList)
                {
                    Console.WriteLine($"Blog: {post.Blog.Name}");
                    Console.WriteLine($"   {post.Title}");
                }
            }
        }
    }
}