FROM nginx:stable

ARG BUILD_DIR=Builds/
ADD $BUILD_DIR /usr/share/nginx/html

WORKDIR /etc/nginx/conf.d
COPY .config/nginx.conf default.conf

EXPOSE 80