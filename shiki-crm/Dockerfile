
#STAGE 1
FROM node:latest AS build
WORKDIR /usr/src/app
COPY package.json package-lock.json ./
RUN npm install
COPY . .
RUN ng build

#STAGE 2
FROM nginx:latest
COPY nginx.conf /etc/nginx/nginx.conf
COPY --from=build /usr/src/app/dist/shiki-crm /usr/share/nginx/html