import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'IssueManagement',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44332/',
    redirectUri: baseUrl,
    clientId: 'IssueManagement_App',
    responseType: 'code',
    scope: 'offline_access IssueManagement',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44332',
      rootNamespace: 'Acme.IssueManagement',
    },
    IssueManagement: {
      url: 'https://localhost:44323',
      rootNamespace: 'Acme.IssueManagement',
    },
  },
} as Environment;
