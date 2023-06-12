Project Tarjeta - Usage Instructions

This repository contains the necessary files to set up the Tarjeta project using Docker Compose.

Prerequisites

Before getting started, make sure you have the following components installed on your machine:

Docker: Installation instructions at https://docs.docker.com/get-docker/

Running the Project in a Local Environment

To run the project on your local machine, follow these steps:

1. Clone this repository to your machine:
git clone https://github.com/FrancoMariani1/TarjetaRepository.git

2. Navigate to the repository directory:
cd YourRepository

3. Run the following command to start the containers using Docker Compose and the cloud configuration:
docker-compose -f docker-compose-cloud.yml up
This command will use the docker-compose-cloud.yml file to create and run the Front, Back, DB, and Nginx containers according to the configurations defined in that file.
Once the containers are up and running,you can access the application in your web browser at http://localhost.

4. To stop and remove the containers, run the following command:
docker-compose -f docker-compose-cloud.yml down

TEAM MEMBERS: Roman Pereyra Yost, Alvaro Garces, Adonai Mariani, Franco Mariani
