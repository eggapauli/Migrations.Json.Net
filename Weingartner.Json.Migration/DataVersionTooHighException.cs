﻿using System;
using Weingartner.Json.Migration.Common;

namespace Weingartner.Json.Migration
{
    public class DataVersionTooHighException : MigrationException
    {
        public DataVersionTooHighException()
        {
        }

        public DataVersionTooHighException(string message) : base(message)
        {
        }

        public DataVersionTooHighException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}