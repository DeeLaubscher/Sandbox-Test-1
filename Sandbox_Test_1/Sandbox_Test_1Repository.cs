﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Sandbox_Test_1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Sandbox_Test_1Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.0")]
    [RepositoryFolder("ed600acb-42aa-4ffa-b740-7a18f9993fcc")]
    public partial class Sandbox_Test_1Repository : RepoGenBaseFolder
    {
        static Sandbox_Test_1Repository instance = new Sandbox_Test_1Repository();

        /// <summary>
        /// Gets the singleton class instance representing the Sandbox_Test_1Repository element repository.
        /// </summary>
        [RepositoryFolder("ed600acb-42aa-4ffa-b740-7a18f9993fcc")]
        public static Sandbox_Test_1Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Sandbox_Test_1Repository() 
            : base("Sandbox_Test_1Repository", "/", null, 0, false, "ed600acb-42aa-4ffa-b740-7a18f9993fcc", ".\\RepositoryImages\\Sandbox_Test_1Repositoryed600acb.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("ed600acb-42aa-4ffa-b740-7a18f9993fcc")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.0")]
    public partial class Sandbox_Test_1RepositoryFolders
    {
    }
#pragma warning restore 0436
}