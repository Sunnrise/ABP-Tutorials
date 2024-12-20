import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'Module',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44363/',
    redirectUri: baseUrl,
    clientId: 'Module_App',
    responseType: 'code',
    scope: 'offline_access Module',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44363',
      rootNamespace: 'Abp.Module',
    },
    Module: {
      url: 'https://localhost:44390',
      rootNamespace: 'Abp.Module',
    },
  },
} as Environment;
