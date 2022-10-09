// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text;

namespace Antlr4Ast;

/// <summary>
/// An element used in a lexer/parser rule to reference another rules.
/// </summary>
public sealed class RuleRef : ElementSyntax
{
    /// <summary>
    /// Creates a new instance of this object.
    /// </summary>
    /// <param name="name">The name of the rule referenced.</param>
    public RuleRef(string name)
    {
        this.Name = name;
    }

    /// <summary>
    /// Gets or sets the name of the rule referenced.
    /// </summary>
    public string Name { get; set; }

    /// <inheritdoc />
    protected override void ToTextImpl(StringBuilder builder, AntlrFormattingOptions options)
    {
        builder.Append(Name);
    }
}