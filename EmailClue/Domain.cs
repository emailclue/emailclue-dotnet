using System;
using System.Collections.Generic;

namespace EmailClue
{

    public class Validation
    {
        public Status Status { get; set; }
        public EmailProvider EmailProvider { get; set; }
        public ErrorType? ErrorType { get; set; }
        public List<string> DidYouMean { get; set; }

        public override string ToString()
        {
            return "Status: " + Status +
                " EmailProvider: " + EmailProvider +
                " ErrorType: " + ErrorType +
                " DidYouMean: " + String.Join(",", DidYouMean);
        }

    }

    public enum Status
    {
        VALID,
        SUSPECT,
        INVALID
    }

    public class EmailProvider
    {
        private string Name { get; set; }
        private string LoginURL { get; set; }
        private string LogoURL { get; set; }

        public override string ToString()
        {
            return "{" +
                " Name: " + Name +
                " LoginURL: " + LoginURL +
                " LogoURL: " + LogoURL +
                " }";
        }
    }

    public class EmailSend
    {
        public string ID { get; set; }
    }

    public enum ErrorType
    {
        LOCAL_PART,
        DOMAIN_PART,
        MISSING_AT,
        DNS,
        MAIL_SERVER,
        DISPOSABLE_EMAIL
    }

}
