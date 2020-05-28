#!/bin/bash

dotnet ef --project MyApi.Data/MyApi.Data.csproj database update
dotnet watch --project MyApi/MyApi.csproj run --urls http://0.0.0.0:5000
