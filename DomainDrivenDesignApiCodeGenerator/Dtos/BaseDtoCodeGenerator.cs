﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace DomainDrivenDesignApiCodeGenerator.Dtos
{
    public abstract class BaseDtoCodeGenerator : BaseCodeGenerator
    {
        protected readonly string _dtoNamespace;
        protected readonly string _modelsNamespace;
        protected readonly bool _isUpdate;
        protected BaseDtoCodeGenerator(string dtoNamespaceS, string classDirectoryPath, string modelsNamespace, string assemblyPath, bool isUpdate) : base(assemblyPath, classDirectoryPath)
        {
            _dtoNamespace = dtoNamespaceS;
            _modelsNamespace = modelsNamespace;
            _isUpdate = isUpdate;
        }

    }
}
