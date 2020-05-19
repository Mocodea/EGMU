export const oidcSettings = {
  authority: 'http://localhost:5000',
  client_id: 'EGMU',
  redirect_uri: 'http://localhost:5000/authentication/login-callback',
  response_type: 'code',
  scope: 'EGMUAPI openid profile',
  silentRedirectUri: 'http://localhost:5000/authentication/silent-signin',
  automaticSilentRenew: true, // If true oidc-client will try to renew your token when it is about to expire
};
