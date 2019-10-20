# GitHub Release - NuGet Workflow

![GitHub top language](https://img.shields.io/github/languages/top/codeaphex/github_release_nuget_workflow?logo=github)
![GitHub License](https://img.shields.io/github/license/codeaphex/github_release_nuget_workflow?logo=github)
![Nuget Downloads](https://img.shields.io/nuget/dt/github_release_nuget_workflow?logo=nuget)

## Status

### Workflow

[![Workflow Badge](https://github.com/codeaphex/github_release_nuget_workflow/workflows/Generate%20NuGet%20package/badge.svg)](https://github.com/codeaphex/github_release_nuget_workflow/blob/master/.github/workflows/release_nuget_workflow.yaml)

### Stable version

![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/codeaphex/github_release_nuget_workflow?sort=semver&logo=github)
![Nuget](https://img.shields.io/nuget/v/github_release_nuget_workflow?logo=nuget)

### Development version

![GitHub release (latest SemVer including pre-releases)](https://img.shields.io/github/v/release/codeaphex/github_release_nuget_workflow?include_prereleases&label=dev%20release&sort=semver&logo=github)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/github_release_nuget_workflow?label=dev%20nuget&logo=nuget)

## Features

- Create and push a NuGet package on a Github Release
- Supports Semantic Versioning 2.0.0 for prerelease packages

## Usage

### Prerequisites

- GitHub project secret named NUGET_TOKEN with a valid NuGet API key is set
- AssemblyVersion of the library matches the GitHub Release version tag  
  Rules: **MAJOR.MINOR.PATCH must match**  
  Example: **AssemblyVersion: 0.1.1**  
  matches the following GitHub release versions:  
  **0.1.1**  
  **v0.1.1**  
  **0.1.1-alpha**  
  **v0.1.1-beta.2**    

### Getting started

1. Copy workflow
1. Set secret
1. Check Assembly version
1. Push
1. Create release
1. Profit!!!
