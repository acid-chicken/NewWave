FROM microsoft/dotnet:2.1-sdk-bionic

MAINTAINER Acid Chicken (硫酸鶏) <root@acid-chicken.com>

RUN apt update \
 && apt upgrade -y \
 && apt install -y software-properties-common \
 && add-apt-repository universe \
 && apt update \
 && apt install -y zsh clang libcurl4-openssl-dev zlib1g-dev libkrb5-dev \
 && apt autoremove -y
