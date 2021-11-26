﻿using System;

namespace Signature.Shared.Models
{
    public class DocumentSigner
    {
        public Guid UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public bool Signed { get; set; }

        public string WalletAddress { get; set; }
    }
}
