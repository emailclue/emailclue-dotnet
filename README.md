# EmailClue .NET Client

Dot Net EmailClue Client Library


Nu-Get
Add to your solution / project via the Nu-Get package manager command line
`Install-Package EmailClue.Client`

Usage

```
using EmailClue

namespace MyApp 
{
    class App 
    {
        public static void Main(string[] args) 
        {
            IEmailClue emailClue = new EmailClue("PUBLIC_TEST_TOKEN");
            var result = emailClue.ValidateEmail("myemail@example.com");
            Console.WriteLine("Valid {0}", result.status);
        }
    }
}
```

More examples can be found in the `ConsoleApp` directory
