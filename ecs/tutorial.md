make sure "image" connects to docker image in ecs_client, ecs_users

"%s" represents the codebuild environment in order

Example:

"image": "%s/dotnet-react-users:prod",

"environment": [
{
"name": "DATABASE_HOST",
"value": "%s"
},
{
"name": "MYSQL_ROOT_PASSWORD",
"value": "%s"
},
{
"name": "MYSQL_USER",
"value": "%s"
}
]

https://aws.amazon.com/codebuild/

Code build environment should be

Feel free to hardcode it meaning just don't put the %s in it

DOCKER_USERNAME: Your Docker_User_Name
MYSQL_USER: admin
DATABASE_HOST: RDS_ENDPOINT_FROM_AWS
MYSQL_ROOT_PASSWORD: PASSWORD

Note! if the order of the environment is not matched then it will be in a different order
Check the task definition json file in aws console.
