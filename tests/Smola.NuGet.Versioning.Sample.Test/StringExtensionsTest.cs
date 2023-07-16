// <copyright file="StringExtensionsTest.cs" company="Mario Smolcic">
//
// Copyright (C) Mario Smolcic.
// You are permitted to fork, copy, or use this content in any other form you can imagine.
//
// </copyright>

namespace Smola.NuGet.Versioning.Sample.Test;

using Xunit;

public class StringExtensionsTest
{
    [Fact]
    public void Given_InputString_When_DoSomethingAmazingIsInvoked_Then_OutputShouldBeDecoratedInputString()
    {
        // Arrange
        const string input = "NuGet Package Versioning Test";

        // Act
        string output = input.DoSomethingAmazing();

        // Assert
        Assert.NotEqual(input, output);
    }
}