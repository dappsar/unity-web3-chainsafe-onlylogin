FROM nginx:alpine

WORKDIR /etc/nginx/conf.d
COPY nginx.conf default.conf

WORKDIR /app
COPY ../Builds/ .

EXPOSE 80