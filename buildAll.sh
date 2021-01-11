#!/usr/bin/env bash

./scripts/generateBindings
dotnet build src/GtkSheetSharp.csproj
dotnet build example/GtkSheetExample.csproj
