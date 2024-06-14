// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using ImageMagick.SourceGenerator;

namespace ImageMagick;

internal static partial class Environment
{
    [NativeInterop]
    private partial class NativeEnvironment
    {
        public static partial void Initialize();

        public static partial string? GetEnv(string name);

        public static partial void SetEnv(string name, string value);
    }
}
