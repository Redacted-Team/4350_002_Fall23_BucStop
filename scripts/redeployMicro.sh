#!/bin/bash

sudo docker pull sirethan/gamemicro

sudo docker compose up --no-deps -d micro

sudo docker image prune -f
