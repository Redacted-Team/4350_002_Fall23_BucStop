#!/bin/bash

sudo docker pull sirethan/bucstop

sudo docker compose up --no-deps -d bucstop

sudo docker image prune -f
