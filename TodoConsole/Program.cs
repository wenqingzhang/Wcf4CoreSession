using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CommandLine;
using TodoServiceClient;

namespace TodoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Parser.Default.ParseArguments<Options>(args)
                    .WithParsed(RunOptionsAndReturnExitCode)
                    .WithNotParsed(HandleParseError);
            }
            catch (Exception e)
            {
                Console.WriteLine($"[{DateTime.Now.ToShortTimeString()}] [ERROR]: {e.Message}");

                Console.WriteLine("Press ENTER to quit app");
                Console.ReadLine();
            }
        }

        private static void HandleParseError(IEnumerable<Error> errs)
        {
            Console.WriteLine("Press ENTER to quit app");
            Console.ReadLine();
        }

        private static void RunOptionsAndReturnExitCode(Options opts)
        {
            var todoRepo = new TodoRepo();
            switch (opts.TodoFeature)
            {
                case Options.TodoFeatures.Create:
                    MakeSureTodoTitle(opts);
                    var item = todoRepo.CreateTodo(opts.TodoTitle);
                    Console.WriteLine($"Created a new TodoItem: [Id={item.Id}, Title=\"{item.Title}\", Done={item.Status}, EoL={item.EoL?.ToString()}]");
                    break;
                case Options.TodoFeatures.Complete:
                    MakeSureTodoId(opts);
                    break;
                case Options.TodoFeatures.Uncomplete:
                    MakeSureTodoId(opts);
                    break;
                case Options.TodoFeatures.Delete:
                    MakeSureTodoId(opts);
                    break;
                default:
                    throw new ArgumentException("feature must be provided");
            }

            Console.WriteLine("Press ENTER to quit app");
            Console.ReadLine();
        }

        private static void MakeSureTodoId(Options opts)
        {
            if (!opts.TodoId.HasValue || opts.TodoId.Value <= 0)
            {
                throw new ArgumentException("id must be provided");
            }
        }

        private static void MakeSureTodoTitle(Options opts)
        {
            if (string.IsNullOrEmpty(opts.TodoTitle))
            {
                throw new ArgumentException("title must be provided");
            }
        }
    }

    public class Options
    {
        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }

        [Option('f', "feature", Required = true, HelpText = "Feature to be invoked.")]
        public TodoFeatures TodoFeature { get; set; }

        [Option('i', "id", Required = false, HelpText = "Id to indicate the Todo item.")]
        public int? TodoId { get; set; }

        [Option('t', "title", Required = false, HelpText = "Title to search the Todo item.")]
        public string TodoTitle { get; set; }

        [Option('s', "status", Required = false, HelpText = "Status to be set to Todo item.")]
        public TodoStates? TodoState { get; set; }

        public enum TodoFeatures
        {
            Create = 1,
            Complete = 2,
            Uncomplete = 3,
            Delete = 4
        }

        public enum TodoStates
        {
            Created = 0,
            Completed = 1,
            Uncompleted = 2,
        }
    }
}
