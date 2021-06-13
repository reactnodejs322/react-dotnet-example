FROM nginx:latest
ADD nginx.conf /etc/nginx/sites-enabled
RUN rm /etc/nginx/conf.d/default.conf
COPY /nginx.conf /etc/nginx/conf.d
# For Https
# COPY nginx-no-ssl.conf /etc/nginx/nginx-no-ssl.conf
# COPY nginx-no-ssl.conf /etc/nginx/nginx-no-ssl.conf
# COPY localhost.crt /etc/ssl/certs/localhost.crt
# COPY localhost.key /etc/ssl/private/localhost.key
# FROM nginx:latest

#  RUN rm /etc/nginx/conf.d/default.conf
#  COPY /prod.conf /etc/nginx/conf.d