||||||**\*** FOR BUILDSPEC.YML **\***||||||

1. For docker hub make sure buildspec.yml has these ROLES

ROLE:

AmazonS3FullAccess

AmazonECS_FullAccess

AmazonEC2ContainerRegistryPowerUser

2. Make sure Codebuild environment has (Becareful with typos!)

DOCKER_USERNAME
MYSQL_USER
DATABASE_HOST
MYSQL_ROOT_PASSWORD

3. Get token from docker hub and upload it to s3 a storage service from aws!

create token and download it https://hub.docker.com/settings/security

upload it to s3

4. Make sure

if expr "$CODEBUILD_WEBHOOK_TRIGGER" == "branch/{POINTS_TO_THE_BRANCH_ON_YOUR_GITHUB}" >/dev/null  && expr "$CODEBUILD_WEBHOOK_HEAD_REF" == "refs/heads/{POINTS_TO_THE_BRANCH_ON_YOUR_GITHUB}" >/dev/null; then on line 11 on codebuild

points the branch on your github

||||||**\*** Deploy.sh **\***||||||

Make sure last few lines POINTS_TO_THE_BRANCH_ON_YOUR_GITHUB

if [ "$CODEBUILD_WEBHOOK_TRIGGER" == "branch/POINTS_TO_THE_BRANCH_ON_YOUR_GITHUB" ] && \
 [ "$CODEBUILD_WEBHOOK_HEAD_REF" == "refs/heads/POINTS_TO_THE_BRANCH_ON_YOUR_GITHUB" ]

CLUSTER
cluster="dotnet-react-cluster" <- MAKE SURE THIS IS RIGHT MATCHES THE CLUSTER

BACKEND
service="react-dotnet-users-service" # MAKE SURE THIS IS RIGHT MATCHES THE SERVICE

CLIENT
service="react-dotnet-client-service" # MAKE SURE THIS IS RIGHT MATCHES THE SERVICE
