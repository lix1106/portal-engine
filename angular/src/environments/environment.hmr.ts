export const environment = {
  production: false,
  hmr: true,
  application: {
    name: 'Portal',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44398',
    clientId: 'Portal_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'Portal',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44376',
    },
  },
  localization: {
    defaultResourceName: 'Portal',
  },
};
