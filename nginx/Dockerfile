# Development Mode

FROM nginx:latest




COPY nginx-development.conf /etc/nginx/nginx.conf
COPY localhost.crt /etc/ssl/certs/localhost.crt
COPY localhost.key /etc/ssl/private/localhost.key





# Hold up bro! Wait for react to start up
# COPY wait-for-it.sh /wait-for-it.sh
# # to make wait-for-it.sh excutable without permission error
# RUN chmod +x /wait-for-it.sh