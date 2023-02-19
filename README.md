![unity](https://img.shields.io/badge/unity-informational?style=flat&logo=unity&logoColor=white&color=6aa6f8)
![web3](https://img.shields.io/badge/web3-informational?style=flat&logo=web3&logoColor=white&color=6aa6f8)
![blockchain](https://img.shields.io/badge/blockchain-informational?style=flat&logo=blockchain&logoColor=white&color=6aa6f8)
![chainsafe](https://img.shields.io/badge/chainsafe-informational?style=flat&logo=chainsafe&logoColor=white&color=6aa6f8)


# Demo Unity App with Web3 Login

## Introduction

A simple demo to show a web3 Login, developed with [chainSafe SDK for Unity](https://github.com/ChainSafe/web3.unity).

![app demo](./.doc/images/demo.png)

![wallets](./.doc/images/wallets.png)


## Technology Stack & Tools

- [Unity](https://unity.com/)
- [Web3](https://en.wikipedia.org/wiki/Web3)
- [C#](https://learn.microsoft.com/es-es/dotnet/csharp/)
- [ChainSafe SDK for Unity](https://github.com/ChainSafe/web3.unity)

## Requirements For Initial Setup

- [Unity Hub](https://unity.com/download)
- [Docker](https://docs.docker.com/engine/install/)
- [Docker-compose]()

## Setting Up

### 1. Clone/Download the Repository
  
  `$ git clone repo_url`

### 2. Open in Unity
  
  - Open folder in Unity (tested in Unity Editor **2021.3.18f1**).
  - Build or Build and Run!.

## 3. Run with Docker

### Using Script

Execute this command to build container:

`$ ./build.sh -n web3-demo -p8120 -d .`

Notes: 
  - _web3-demo_: It is the container name 
  - _'.'_: It indicates the sub-folder within the 'Builds' folder that contains the build files. Assumes the files are in the root of builds folder.

Open browser in: http://localhost:8120

### Using docker-compose

Execute this command to build and start container:

  `$ docker-compose up -d`

Open browser in http://localhost:8120

### Demo

- video: ![demo](./.doc/media/ChainSafeDemo.gif)


# References

- [ChainSafe Web3 Unity SDK](https://docs.gaming.chainsafe.io/)
- [Unity Engine + MetaMask Wallet](https://medium.com/coinmonks/unity-engine-metamask-wallet-6797d4699e45)
- [Chainsafe Gaming SDK - Making Blockchain Games Plug & Play](https://www.youtube.com/watch?v=qa2TatYgvYs)
- [Goerli Faucet](https://goerli-faucet.pk910.de/)


